using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventVector2 EventVector2Response;

		// -- Public Functions
		public void OnEventRaised(Vector2 value)
		{
			EventVector2Response.Invoke(value);
		}
	}
}