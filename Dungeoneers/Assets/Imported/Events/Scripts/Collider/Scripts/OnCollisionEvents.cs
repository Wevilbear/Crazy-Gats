using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Helpers.Colliders
{
	[RequireComponent(typeof(Collider))]
	public class OnCollisionEvents : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] UnityEventGameObject onCollisionEnter;
		[SerializeField] UnityEventGameObject onCollisionExit;
		[SerializeField] UnityEventGameObject onCollisionStay;

		// -- Private Functions
		private void OnCollisionEnter(Collision collision)
		{
			onCollisionEnter.Invoke(collision.gameObject);
		}

		private void OnCollisionExit(Collision collision)
		{
			onCollisionExit.Invoke(collision.gameObject);
		}

		private void OnCollisionStay(Collision collision)
		{
			onCollisionStay.Invoke(collision.gameObject);
		}
	}
}