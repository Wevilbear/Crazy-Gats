using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	GameObject controlledObject;
	Collider2D controlledCollider;
	float dtSpeed;

	[SerializeField] int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
		controlledObject = gameObject;
		if (controlledObject == null)
			enabled = false;

		controlledCollider = controlledObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
		dtSpeed = Time.deltaTime * moveSpeed;

		if (Input.GetButton("Up"))
		{
			transform.Translate(Vector2.up * dtSpeed);
		}
		else if (Input.GetButton("Down"))
		{
			transform.Translate(Vector2.down * dtSpeed);
		}

		if (Input.GetButton("Right"))
		{
			transform.Translate(Vector2.right * dtSpeed);
		}
		else if (Input.GetButton("Left"))
		{
			transform.Translate(Vector2.left * dtSpeed);
		}
	}
}
