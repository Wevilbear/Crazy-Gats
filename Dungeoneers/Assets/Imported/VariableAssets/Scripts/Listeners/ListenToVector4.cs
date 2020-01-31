using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Variables
{
	public class ListenToVector4 : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] VariableVector4 variable;
		[SerializeField] UnityEventVector4 onValueChanged;

		// -- Private Values
		private Vector4 lastFrameValue;

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