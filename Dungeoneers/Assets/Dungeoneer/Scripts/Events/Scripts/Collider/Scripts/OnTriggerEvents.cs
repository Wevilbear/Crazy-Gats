using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Helpers.Colliders
{
	[RequireComponent(typeof(Collider))]
	public class OnTriggerEvents : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] UnityEventGameObject onTriggerEnter;
		[SerializeField] UnityEventGameObject onTriggerExit;
		[SerializeField] UnityEventGameObject onTriggerStay;

		// -- Private Functions
		private void OnTriggerEnter(Collider other)
		{
			onTriggerEnter.Invoke(other.gameObject);
		}

		private void OnTriggerExit(Collider other)
		{
			onTriggerExit.Invoke(other.gameObject);
		}

		private void OnTriggerStay(Collider other)
		{
			onTriggerStay.Invoke(other.gameObject);
		}
	}
}