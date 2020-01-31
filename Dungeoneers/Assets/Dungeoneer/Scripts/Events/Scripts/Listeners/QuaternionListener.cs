using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public partial class EventListener
	{
		// -- Field Values
		[SerializeField] UnityEventQuaternion EventQuaternionResponse;

		// -- Public Functions
		public void OnEventRaised(Quaternion value)
		{
			EventQuaternionResponse.Invoke(value);
		}
	}
}