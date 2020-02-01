
using ATXK.Helpers.UnityEvents;
using ATXK.Systems.Event;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
	[SerializeField] int moveSpeed = 1;

	[Space]
	[SerializeField] Animator animator;

	[Space]
	[SerializeField] int interactDist = 1;
	[SerializeField] string interactLayer = "Interactable";
	[SerializeField] EventDefault interactEvent;

	[Space]
	[SerializeField] List<StaffPart> requiredParts;
	[SerializeField] UnityEventDefault staffComplete;

	[Space]
	[SerializeField] int attackDist = 1;

	Rigidbody2D rb;
	Vector2 movement;
	Vector2 fakeForward;
	bool staffCompleted;
	bool noodleArm;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		fakeForward = transform.forward;
		staffCompleted = false;
		noodleArm = false;
	}

	void Update()
	{
		//Debug.DrawRay(transform.position, fakeForward * interactDist, Color.red);

		Movement();
		HandleStaff();

		animator.SetFloat("Horizontal", fakeForward.x);
		animator.SetFloat("Vertical", fakeForward.y);
		animator.SetFloat("Speed", rb.velocity.magnitude);
	}

	// --- PLAYER UPDATE CODES --- //

	void Movement()
	{
		movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		rb.velocity = movement * moveSpeed;
		if (rb.velocity.normalized != Vector2.zero)
			fakeForward = rb.velocity.normalized;
	}

	public void Attack()
	{
		float range = 99999f;
		if(!noodleArm)
		{
			range = 4f;
		}
		else
		{
			range = 15f;
		}
		RaycastHit2D hit = Physics2D.Raycast(transform.position, fakeForward, range, 1 << LayerMask.NameToLayer("DamagedGoods"));
		if(hit)
		{
			Debug.DrawRay(transform.position, fakeForward * range, Color.red);
			if (hit.transform.CompareTag("Wall"))
			{
				hit.transform.gameObject.GetComponent<Wall>().wallHP -= 1;
				Debug.Log("Pow");
			}
			if (hit.transform.CompareTag("Enemy"))
			{
				hit.transform.gameObject.GetComponent<Unit>().HP -= 1;
				Debug.Log("bam");
			}
		}
	}

	// --- PLAYER INTERACTION CODES --- //
	public void Interact()
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.position, fakeForward, interactDist, 1 << LayerMask.NameToLayer(interactLayer));
		if (hit)
		{
			interactEvent.Invoke(hit.transform.gameObject.GetInstanceID());
		}
	}

	// --- PLAYER ITEM PICKUP CODES --- //
	public void PickUpItem(StaffPart item)
	{
		if (requiredParts.Contains(item))
		{
			requiredParts.Remove(item);
			item.gameObject.SetActive(false);
		}
	}

	void HandleStaff()
	{
		if (staffCompleted)
			return;

		// All parts collected.
		if(requiredParts.Count <= 0)
		{
			staffCompleted = true;
			staffComplete.Invoke();
		}
	}
}
