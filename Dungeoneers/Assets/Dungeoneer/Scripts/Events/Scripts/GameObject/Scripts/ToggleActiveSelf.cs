using UnityEngine;

namespace ATXK.Helpers.GameObjects
{
	public class ToggleActiveSelf : MonoBehaviour
	{
		// -- Public Functions
		public void Toggle()
		{
			gameObject.SetActive(!gameObject.activeSelf);
		}
	}
}