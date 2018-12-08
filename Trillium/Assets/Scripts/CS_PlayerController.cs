using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PlayerController : CT_PlayerInput
{
    private GameObject this_Player;
    private Collider this_Collider;
    private Rigidbody this_Rigidbody;

    // Use this for initialization
    new void Start ()
    {
        this_Player = gameObject;
        this_Collider = this_Player.GetComponent<Collider>();
        this_Rigidbody = this_Player.GetComponent<Rigidbody>();

        // Run CT_PlayerInput's Start Function
        base.Start();
    }

    // Input
    void PlayerInput()
    {
        // Temporary Vector 3 for input
        Vector3 tempInput = new Vector3();

        tempInput = base.GetInputVector();
    }
	
	// Update is called once per frame
	new void Update ()
    {
        
	}
}
