using UnityEditor;

namespace ATXK.Systems.Event
{
	[CustomEditor(typeof(EventListener))]
	[CanEditMultipleObjects]
	public partial class ListenerInspector : Editor
	{
		public override void OnInspectorGUI()
		{
			serializedObject.Update();

			EventListener listener = (EventListener)target;

			// Event Array
			EditorGUILayout.LabelField("Events", EditorStyles.boldLabel);

			SerializedProperty listeningToEvent = serializedObject.FindProperty("listeningToEvent");
			EditorGUI.BeginChangeCheck();
			EditorGUILayout.PropertyField(listeningToEvent, true);
			if (EditorGUI.EndChangeCheck())
				serializedObject.ApplyModifiedProperties();

			// Handle various event types
			EventBase abstractedEvent = listeningToEvent.objectReferenceValue as EventBase;
			string responsePropertyName = abstractedEvent.GetType().Name + "Response";
			SerializedProperty property = serializedObject.FindProperty(responsePropertyName);

			//UnityEngine.Debug.Log("Property: " + responsePropertyName);

			// If property is not null, then display it.
			if (property != null)
			{
				EditorGUILayout.LabelField("OnInvoked", EditorStyles.boldLabel);
				EditorGUILayout.PropertyField(property);
			}

			serializedObject.ApplyModifiedProperties();
		}
	}
}