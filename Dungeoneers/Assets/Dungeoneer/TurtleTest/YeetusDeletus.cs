using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class YeetusDeletus : MonoBehaviour
{
    private NavMeshAgent hello;
    // Start is called before the first frame update
    void Start()
    {
        hello = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hi;

            if (Physics.Raycast(ray, out hi))
            {
                if (hi.collider.tag == "Ground")
                {
                    hello.SetDestination(hi.point);
                }
            }

        }
    }
}
