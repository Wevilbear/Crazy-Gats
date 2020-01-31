using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventInt EventIntResponse;

		// -- Public Functions
		public void OnEventRaised(int value)
		{
			EventIntResponse.Invoke(value);
		}
	}
}