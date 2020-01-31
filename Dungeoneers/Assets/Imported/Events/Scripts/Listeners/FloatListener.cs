using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventFloat EventFloatResponse;

		// -- Public Functions
		public void OnEventRaised(float value)
		{
			EventFloatResponse.Invoke(value);
		}
	}
}