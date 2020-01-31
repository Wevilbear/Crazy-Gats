using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventGameObject EventGameObjectResponse;

		// -- Public Functions
		public void OnEventRaised(GameObject value)
		{
			EventGameObjectResponse.Invoke(value);
		}
	}
}