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
        // Run CT_PlayerInput's Start Function
        base.Start();

        this_Player = gameObject;
        this_Collider = this_Player.GetComponent<Collider>();
        this_Rigidbody = this_Player.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update()
    {
        // Update all player input information
        base.EvaluateInput();

        // Gather current player input
        Vector3 v3_playerInput = base.GetInputVector();
        float yVel = this_Rigidbody.velocity.y;
        Vector3 v3_tempVelocity = new Vector3();

        v3_tempVelocity = v3_playerInput * 5.0f;

        if( base.GetJumpButton() == JumpButtonState.Pressed )
        {
            v3_tempVelocity += Vector3.up * 5f;
        }

        v3_tempVelocity.y += yVel;

        this_Rigidbody.velocity = v3_tempVelocity;
    }
}
