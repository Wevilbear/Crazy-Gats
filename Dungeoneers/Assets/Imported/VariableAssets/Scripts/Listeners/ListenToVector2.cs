using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Variables
{
	public class ListenToVector2 : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] VariableVector2 variable;
		[SerializeField] UnityEventVector2 onValueChanged;

		// -- Private Values
		private Vector2 lastFrameValue;

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