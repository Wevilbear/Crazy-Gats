using UnityEngine;

namespace ATXK.Systems.Event
{
	[CreateAssetMenu(menuName = "Event/Vector3", order = 8)]
	public class EventVector3 : EventGenericData<Vector3>
	{
		public override void Invoke()
		{
			foreach(EventListener listener in listeners)
			{
				listener.OnEventRaised(Value);
			}
		}

		public override void Invoke(int? listenerInstanceID)
		{
			if(listenerInstanceID == null)
			{
				Invoke();
				return;
			}

			foreach(EventListener listener in listeners)
			{
				if (listener.ObjectID == listenerInstanceID)
				{
					listener.OnEventRaised(Value);
				}
			}
		}

		public override void Invoke(Vector3 value)
		{
			Value = value;
			Invoke();
		}

		public override void Invoke(Vector3 value, int? listenerInstanceID)
		{
			Value = value;
			Invoke(listenerInstanceID);
		}
	}
}