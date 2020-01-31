using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ATXK.Systems.Event;
using ATXK.Helpers.UnityEvents;

public class Door : MonoBehaviour
{
	[SerializeField] bool isLocked;
	[SerializeField] UnityEventDefault openSuccess;
	[SerializeField] UnityEventDefault openFail;

	public void Open()
	{
		if (isLocked)
			openSuccess.Invoke();
		else
			openFail.Invoke();
	}

	public void Unlock()
	{
		isLocked = false;
	}

	public void Lock()
	{
		isLocked = true;
	}
}
