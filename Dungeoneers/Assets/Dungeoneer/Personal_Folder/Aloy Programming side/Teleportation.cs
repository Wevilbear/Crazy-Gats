using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject T_Target;
    public GameObject T_Target2;
    public GameObject Player;
 
    //bool B_Teleporter;
    //bool B_Teleporter_reciever;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //if player hit onto the game object of teleporter they will change area
        {
            other.transform.position = new Vector2 (T_Target.transform.position.x - 15, T_Target.transform.position.y);//go to portal 1
            //B_Teleporter = false;
        }
        if (other.gameObject.tag == "Player") //if player hit onto the game object of teleporter they will change area
        {
            other.transform.position = new Vector2(T_Target2.transform.position.x - 15, T_Target2.transform.position.y); //go to portal 2
            //B_Teleporter_reciever = false;
        }
    }
}
