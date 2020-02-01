
using ATXK.Systems.Event;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
	[SerializeField] int moveSpeed = 1;
	[SerializeField] int interactDist = 1;
	[SerializeField] string interactLayer = "Interactable";
	[SerializeField] EventDefault interactEvent;

	Rigidbody2D rb;
	Vector2 movement;
	Vector2 fakeForward;
	bool noodleArm;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		fakeForward = transform.forward;
		noodleArm = false;
	}

	void Update()
	{
		Debug.DrawRay(transform.position, fakeForward * 10, Color.red);

		Movement();
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
			if(hit.transform.gameObject.GetComponent<Wall>())
			{
				hit.transform.gameObject.GetComponent<Wall>().wallHP -= 1;
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
}
