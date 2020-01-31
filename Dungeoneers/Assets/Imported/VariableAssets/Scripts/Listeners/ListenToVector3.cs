using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Variables
{
	public class ListenToVector3 : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] VariableVector3 variable;
		[SerializeField] UnityEventVector3 onValueChanged;

		// -- Private Values
		private Vector3 lastFrameValue;

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