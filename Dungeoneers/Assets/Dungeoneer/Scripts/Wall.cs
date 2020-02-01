using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int wallHP;

    // Update is called once per frame
    void Update()
    {
        if(wallHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
