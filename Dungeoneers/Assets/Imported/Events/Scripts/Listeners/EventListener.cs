using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] EventBase listeningToEvent;
		[SerializeField] UnityEventDefault EventDefaultResponse;

		// -- Properties
		public int ObjectID { get { return gameObject.GetInstanceID(); } }

		// -- Private Functions
		private void OnEnable()
		{
			if (listeningToEvent != null)
				listeningToEvent.AddListener(this);
		}

		private void OnDisable()
		{
			if (listeningToEvent != null)
				listeningToEvent.RemoveListener(this);
		}

		// -- Public Functions
		public void OnEventRaised()
		{
			EventDefaultResponse.Invoke();
		}
	}
}