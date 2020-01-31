using UnityEngine;

namespace ATXK.Systems.Event
{
	[CreateAssetMenu(menuName = "Event/Integer", order = 3)]
	public class EventInt : EventGenericData<int>
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

		public override void Invoke(int value)
		{
			Value = value;
			Invoke();
		}

		public override void Invoke(int value, int? listenerInstanceID)
		{
			Value = value;
			Invoke(listenerInstanceID);
		}
	}
}