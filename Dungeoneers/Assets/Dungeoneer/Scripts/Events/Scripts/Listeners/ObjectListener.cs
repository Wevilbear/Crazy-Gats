using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventObject EventObjectResponse;

		// -- Public Functions
		public void OnEventRaised(Object value)
		{
			EventObjectResponse.Invoke(value);
		}
	}
}