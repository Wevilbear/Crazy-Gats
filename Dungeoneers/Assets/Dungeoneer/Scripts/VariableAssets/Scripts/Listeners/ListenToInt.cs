using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Variables
{
	public class ListenToInt : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] VariableInt variable;
		[SerializeField] UnityEventInt onValueChanged;

		// -- Private Values
		private int lastFrameValue;

		// -- Private Functions
		private void Start()
		{
			if (variable != null)
				lastFrameValue = variable.Value;
		}

		private void Update()
		{
			if (variable == null)
				return;
			if (lastFrameValue != variable.Value)
				onValueChanged.Invoke(variable.Value);

			lastFrameValue = variable.Value;
		}
	}
}