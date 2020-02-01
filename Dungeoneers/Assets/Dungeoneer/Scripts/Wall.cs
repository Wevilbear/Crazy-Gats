using ATXK.Helpers.UnityEvents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int wallHP;
	public UnityEventDefault wallDie;

    // Update is called once per frame
    void Update()
    {
        if(wallHP <= 0)
        {
			wallDie.Invoke();
            gameObject.SetActive(false);
        }
    }
}
