using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
	[SerializeField] int moveSpeed;

	Rigidbody2D rb;
	Vector2 movement;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		movement = new Vector2(Input.GetAxis("MoveHorizontal"), Input.GetAxis("MoveVertical"));
		rb.velocity = movement * moveSpeed;
	}
}
