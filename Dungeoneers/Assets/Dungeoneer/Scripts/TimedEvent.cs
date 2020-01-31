using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ATXK.Helpers.UnityEvents;

public class TimedEvent : MonoBehaviour
{
	[SerializeField] float timeToEvent = 1f;
	[SerializeField] UnityEventDefault timesUp;

	float liveTimer;
	bool stopInvoke;

	private void Update()
	{
		if (stopInvoke)
			return;

		liveTimer -= Time.deltaTime;
		if(liveTimer <= 0f)
		{
			timesUp.Invoke();
			stopInvoke = true;
		}
	}

	public void StartTimer()
	{
		liveTimer = timeToEvent;
		stopInvoke = false;
	}
}
