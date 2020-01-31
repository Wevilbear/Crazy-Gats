using System.Collections.Generic;
using UnityEngine;

namespace ATXK.Systems.Event
{
	public abstract class EventBase : ScriptableObject
	{
		// -- Protected Values
		protected List<EventListener> listeners = new List<EventListener>();

		// -- Properties
		public List<EventListener> Listeners { get { return listeners; } }

		// -- Protected Functions
		protected bool ContainsListener(EventListener listener)
		{
			if (listener == null)
				return false;
			return listeners.Contains(listener);
		}

		// -- Public Functions
		public virtual void Invoke()
		{
			foreach(EventListener listener in listeners)
			{
				listener.OnEventRaised();
			}
		}

		public virtual void Invoke(int? listenerInstanceID)
		{
			if (listenerInstanceID == null)
			{
				Invoke();
				return;
			}

			foreach(EventListener listener in listeners)
			{
				if (listener.ObjectID == listenerInstanceID)
					listener.OnEventRaised();
			}
		}

		public virtual void AddListener(EventListener listener)
		{
			if (ContainsListener(listener))
				return;

			listeners.Add(listener);
		}

		public virtual void RemoveListener(EventListener listener)
		{
			if (!ContainsListener(listener))
				return;

			listeners.Remove(listener);
		}
	}

	public abstract class EventGenericData<T> : EventBase
	{
		// -- Public Values
		public T Value;

		// -- Public Functions
		public abstract override void Invoke();

		public abstract override void Invoke(int? listenerInstanceID);

		public abstract void Invoke(T value);

		public abstract void Invoke(T value, int? listenerInstanceID);
	}
}