using ATXK.Helpers.UnityEvents;
using UnityEngine;

namespace ATXK.Systems.Variables
{
	public class ListenToBool : MonoBehaviour
	{
        // -- Field Values
        [SerializeField] bool flipValue;
		[SerializeField] VariableBool variable;
		[SerializeField] UnityEventBool onValueChanged;

		// -- Private Values
		private bool lastFrameValue;

		// -- Private Functions
		private void Start()
		{
			if(variable != null)
            {
                lastFrameValue = variable.Value;
            }
		}

		private void Update()
		{
			if (variable == null)
				return;

            if(lastFrameValue != variable.Value)
            {
                if (flipValue)
                    onValueChanged.Invoke(!variable.Value);
                else
                    onValueChanged.Invoke(variable.Value);
            }

			lastFrameValue = variable.Value;
		}
	}
}