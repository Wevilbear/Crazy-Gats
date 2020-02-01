using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int wallHP;
    // Start is called before the first frame update
    void Start()
    {
        wallHP = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(wallHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
