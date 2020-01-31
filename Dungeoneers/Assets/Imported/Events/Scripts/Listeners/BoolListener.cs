using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventBool EventBoolResponse;

		// -- Public Functions
		public void OnEventRaised(bool value)
		{
			EventBoolResponse.Invoke(value);
		}
	}
}