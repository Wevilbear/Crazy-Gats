using UnityEngine;

namespace ATXK.Systems.Inputs
{
	public class InputDetector
	{
		// -- Public Functions
		public static bool GetKeyDown(KeyAsset key)
		{
			if (key == null)
				return false;

			return Input.GetKeyDown(key.KeyCode);
		}

		public static bool GetKeyUp(KeyAsset key)
		{
			if (key == null)
				return false;

			return Input.GetKeyUp(key.KeyCode);
		}

		public static bool GetKeyHeld(KeyAsset key)
		{
			if (key == null)
				return false;

			return Input.GetKey(key.KeyCode);
		}
	}
}