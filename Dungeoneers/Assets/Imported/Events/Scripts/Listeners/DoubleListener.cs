using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventDouble EventDoubleResponse;

		// -- Public Functions
		public void OnEventRaised(double value)
		{
			EventDoubleResponse.Invoke(value);
		}
	}
}