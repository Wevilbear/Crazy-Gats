using UnityEditor;
using UnityEngine;

namespace ATXK.Systems.Event
{
	[CustomEditor(typeof(EventBase), true)]
	[CanEditMultipleObjects]
	public class EventInspector : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			EventBase gameEvent= (EventBase)target;
			if (GUILayout.Button("Invoke Event"))
			{
				gameEvent.Invoke();
			}
		}
	}
}