using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ATXK.Systems.Inputs
{
	public class InputHandler : MonoBehaviour
	{
		[System.Serializable]
		private class InputSet
		{
			public KeyAsset key;
			public UnityEvent onKeyDown;
			public UnityEvent onKeyUp;
			public UnityEvent onKeyHeld;

			public void HandleInput()
			{
				if (InputDetector.GetKeyDown(key))
					onKeyDown.Invoke();
				if (InputDetector.GetKeyUp(key))
					onKeyUp.Invoke();
				if (InputDetector.GetKeyHeld(key))
					onKeyHeld.Invoke();
			}
		}

		// -- Field Values
		[SerializeField] List<InputSet> inputs = new List<InputSet>();

		// -- Private Functions
		private void Update()
		{
			foreach(InputSet input in inputs)
			{
				input.HandleInput();
			}
		}
	}
}