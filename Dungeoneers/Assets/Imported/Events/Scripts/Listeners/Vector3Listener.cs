using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventVector3 EventVector3Response;

		// -- Public Functions
		public void OnEventRaised(Vector3 value)
		{
			EventVector3Response.Invoke(value);
		}
	}
}