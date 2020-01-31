﻿using UnityEngine;

namespace ATXK.Systems.Event
{
	[CreateAssetMenu(menuName = "Event/Double", order = 5)]
	public class EventDouble : EventGenericData<double>
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

		public override void Invoke(double value)
		{
			Value = value;
			Invoke();
		}

		public override void Invoke(double value, int? listenerInstanceID)
		{
			Value = value;
			Invoke(listenerInstanceID);
		}
	}
}