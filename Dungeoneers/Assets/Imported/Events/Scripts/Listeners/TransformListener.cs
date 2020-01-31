using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventTransform EventTransformResponse;

		// -- Public Functions
		public void OnEventRaised(Transform value)
		{
			EventTransformResponse.Invoke(value);
		}
	}
}