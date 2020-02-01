using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Helpers.Colliders
{
	[RequireComponent(typeof(Collider2D))]
	public class OnCollisionEvents : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] UnityEventGameObject onCollisionEnter;
		[SerializeField] UnityEventGameObject onCollisionExit;
		[SerializeField] UnityEventGameObject onCollisionStay;

		// -- Private Functions
		private void OnCollisionEnter2D(Collision2D collision)
		{
			onCollisionEnter.Invoke(collision.gameObject);
		}

		private void OnCollisionExit2D(Collision2D collision)
		{
			onCollisionExit.Invoke(collision.gameObject);
		}

		private void OnCollisionStay2D(Collision2D collision)
		{
			onCollisionStay.Invoke(collision.gameObject);
		}
	}
}