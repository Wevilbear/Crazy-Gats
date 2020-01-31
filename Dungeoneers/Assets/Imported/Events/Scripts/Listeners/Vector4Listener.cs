using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventVector4 EventVector4Response;

		// -- Public Functions
		public void OnEventRaised(Vector4 value)
		{
			EventVector4Response.Invoke(value);
		}
	}
}