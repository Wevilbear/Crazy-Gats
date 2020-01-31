using UnityEngine;

namespace ATXK.Systems.Variables
{
	public abstract class VariableBase<T> : ScriptableObject
	{
		// -- Field Values
		public T Value;

		// -- Public Functions
		public virtual bool Equals(T amount)
		{
			return amount.Equals(Value);
		}

        public virtual void SetValue(T amount)
        {
            Value = amount;
        }
	}
}