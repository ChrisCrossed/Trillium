using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CT_PlayerInput : MonoBehaviour
{
    // Private Vectors
    private Vector3 v3_InputVector;

	// Use this for initialization
	internal virtual void Start()
    {
        // Reset Vectors
        v3_InputVector = new Vector3();
	}

    void EvaluateInputVector()
    {
        Vector3 tempVector = new Vector3();

        // Evaluate input & assign to vector
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            tempVector.x = 1.0f;
        else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
            tempVector.x = -1.0f;

        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            tempVector.y = -1.0f;
        else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
            tempVector.y = 1.0f;

        // Normalize Vector
        tempVector.Normalize();

        // Assign temp vector to variable
        v3_InputVector = tempVector;
    }

    internal Vector3 GetInputVector()
    {
        return v3_InputVector;
    }
	
	// Update is called once per frame
	internal virtual void Update()
    {
        EvaluateInputVector();
	}
}
