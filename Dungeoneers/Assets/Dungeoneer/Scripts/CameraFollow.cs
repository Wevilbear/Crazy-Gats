using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] GameObject follow;
	[SerializeField] float speed = 5;
	[SerializeField] float zOffset = -10;

	Vector3 lerpPos;

	private void Update()
	{
		if (follow == null)
			enabled = false;

		lerpPos = new Vector3(transform.position.x, transform.position.y, zOffset);
		lerpPos.x = Mathf.Lerp(transform.position.x, follow.transform.position.x, speed * Time.deltaTime);
		lerpPos.y = Mathf.Lerp(transform.position.y, follow.transform.position.y, speed * Time.deltaTime);

		transform.position = lerpPos;
	}
}
