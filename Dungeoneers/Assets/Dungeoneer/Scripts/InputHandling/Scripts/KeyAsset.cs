using UnityEngine;

namespace ATXK.Systems.Inputs
{
	[CreateAssetMenu(menuName = "Input/Key")]
	public class KeyAsset : ScriptableObject
	{
		// -- Field Values
		[SerializeField] string keyName;
		[SerializeField, TextArea] string keyDescription;
		[SerializeField] KeyCode keyDefault;

		// -- Private Values
		private KeyCode runtimeKeyCode;

		// -- Properties
		public string KeyName { get { return keyName; } }
		public string KeyDescription { get { return keyDescription; } }
		public KeyCode KeyCode
		{
			get
			{
				if (runtimeKeyCode == KeyCode.None)
					runtimeKeyCode = LoadKey();
				return runtimeKeyCode;
			}
			set
			{
				runtimeKeyCode = value;
				SaveKey();
			}
		}

		// -- Public Functions
		public void SaveKey()
		{
			PlayerPrefs.SetString(keyName, KeyCode.ToString());
		}

		public KeyCode LoadKey()
		{
			if (PlayerPrefs.HasKey(keyName))
			{
				return runtimeKeyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(keyName));
			}
			return keyDefault;
		}
	}
}