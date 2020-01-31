using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    Transform T_Target = null;
    Transform T_Target2 = null;

    bool B_Teleporter;
    bool B_Teleporter_reciever;

    // Start is called before the first frame update
    void Start()
    {
        B_Teleporter = false;
        B_Teleporter_reciever = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Teleport_1" && B_Teleporter == false && B_Teleporter_reciever == false)
        {
            this.transform.position = T_Target.position;
            B_Teleporter = true;
        }
        if (other.gameObject.tag == "Teleport_2" && B_Teleporter == false && B_Teleporter_reciever == false)
        {
            this.transform.position = T_Target2.position;
            B_Teleporter_reciever = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Teleport_1")
        {
            B_Teleporter = true;
        }
        if (other.gameObject.tag == "Teleport_2")
        {
            B_Teleporter_reciever = true;
        }
    }
}
