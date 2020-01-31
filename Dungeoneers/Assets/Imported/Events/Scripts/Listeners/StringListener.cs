using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventString EventStringResponse;

		// -- Public Functions
		public void OnEventRaised(string value)
		{
			EventStringResponse.Invoke(value);
		}
	}
}