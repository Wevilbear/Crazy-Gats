using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Variables
{
	public class ListenToQuaternion : MonoBehaviour
	{
		// -- Field Values
		[SerializeField] VariableQuaternion variable;
		[SerializeField] UnityEventQuaternion onValueChanged;

		// -- Private Values
		private Quaternion lastFrameValue;

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