using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cs_Test_Vehicle_Trigger : MonoBehaviour
{
    GameObject parentVehicle;

    // Start is called before the first frame update
    void Start()
    {
        parentVehicle = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Player")
        {
            print("Player Enter");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if( other.tag == "Player" )
        {
            print("Player Exit");
        }
    }
}
