using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	
	public Transform target;
	public float speed = 1;

	Vector2[] path;
	GameObject[] pathObj;
	int targetIndex;
	public string tagname;

	void Start() {
		pathObj = GameObject.FindGameObjectsWithTag(tagname);
		StartCoroutine(RefreshPath());
	}

	IEnumerator RefreshPath() {
		while (true)
		{
			if (Input.GetMouseButtonDown(0))
			{
				Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				int arrayIndex = 0;
				float distanceCheck = 1000000.0f;

				for (int i = 0; i < pathObj.Length; i++)
				{
					if (distanceCheck > ((Vector2)mousePosition - (Vector2)pathObj[i].transform.position).magnitude)
					{
						distanceCheck = ((Vector2)mousePosition - (Vector2)pathObj[i].transform.position).magnitude;
						arrayIndex = i;
					}
				}
				path = Pathfinding.RequestPath(transform.position, (Vector2)pathObj[arrayIndex].transform.position);
				StopCoroutine("FollowPath");
				StartCoroutine("FollowPath");
			}
			yield return new WaitForSeconds(.01f);
		}

	}
		
	IEnumerator FollowPath() {
		if (path.Length > 0) {
			targetIndex = 0;
			Vector2 currentWaypoint = path [0];

			while (true) {
				if ((Vector2)transform.position == currentWaypoint) {
					targetIndex++;
					if (targetIndex >= path.Length) {
						yield break;
					}
					currentWaypoint = path [targetIndex];
				}
				Vector3 targettt = new Vector3(currentWaypoint.x, currentWaypoint.y, transform.position.z);
				transform.position = Vector3.MoveTowards (transform.position, targettt, 1.0f * Time.deltaTime);
				transform.position.Set(transform.position.x, transform.position.y, -0.5f);
				yield return null;

			}
		}
	}

	public void OnDrawGizmos() {
		if (path != null) {
			for (int i = targetIndex; i < path.Length; i ++) {
				Gizmos.color = Color.black;
				//Gizmos.DrawCube((Vector3)path[i], Vector3.one *.5f);

				if (i == targetIndex) {
					Gizmos.DrawLine(transform.position, path[i]);
				}
				else {
					Gizmos.DrawLine(path[i-1],path[i]);
				}
			}
		}
	}
}
