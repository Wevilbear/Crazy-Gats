using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Helpers.Colliders
{
	[RequireComponent(typeof(Collider2D))]
	public class OnTriggerEvents : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] UnityEventGameObject onTriggerEnter;
		[SerializeField] UnityEventGameObject onTriggerExit;
		[SerializeField] UnityEventGameObject onTriggerStay;

		// -- Private Functions
		private void OnTriggerEnter2D(Collider2D other)
		{
			onTriggerEnter.Invoke(other.gameObject);
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			onTriggerExit.Invoke(other.gameObject);
		}

		private void OnTriggerStay2D(Collider2D other)
		{
			onTriggerStay.Invoke(other.gameObject);
		}
	}
}