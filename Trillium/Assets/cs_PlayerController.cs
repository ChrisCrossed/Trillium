using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cs_PlayerController : MonoBehaviour
{
    private GameObject this_Player;
    private Collider this_Collider;
    private Rigidbody this_Rigidbody;

    // Use this for initialization
    void Start ()
    {
        this_Player = gameObject;
        this_Collider = this_Player.GetComponent<Collider>();
        this_Rigidbody = this_Player.GetComponent<Rigidbody>();
    }

    // Input
    void PlayerInput()
    {
        // Temporary Vector 3 for input
        Vector3 tempInput = new Vector3();


    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
