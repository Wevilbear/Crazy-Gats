using UnityEngine;

namespace ATXK.Systems.Event
{
	[CreateAssetMenu(menuName = "Event/String", order = 6)]
	public class EventString : EventGenericData<string>
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

		public override void Invoke(string value)
		{
			Value = value;
			Invoke();
		}

		public override void Invoke(string value, int? listenerInstanceID)
		{
			Value = value;
			Invoke(listenerInstanceID);
		}
	}
}