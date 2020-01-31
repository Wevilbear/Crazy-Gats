using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Variables
{
	public class ListenToDouble : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] VariableDouble variable;
		[SerializeField] UnityEventDouble onValueChanged;

		// -- Private Values
		private double lastFrameValue;

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