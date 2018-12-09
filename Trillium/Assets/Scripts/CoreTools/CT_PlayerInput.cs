using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum JumpButtonState
{
    Off,
    Held,
    Pressed
}

public struct PlayerInputObject
{
    private float _f_zDir;
    private float _f_xDir;

    public Vector3 InputVector { internal set; get; }

    public bool JumpButtonPressed { internal set; get; }
}

public class CT_PlayerInput : MonoBehaviour
{
    // Private Vectors
    internal PlayerInputObject playerInput;

    // Private Information
    private JumpButtonState jumpButtonState;

	// Use this for initialization
	internal virtual void Start()
    {
        // Reset Player Objects
        playerInput = new PlayerInputObject();
        jumpButtonState = new JumpButtonState();
	}

    internal void EvaluateInput()
    {
        #region Input Vector3
        Vector3 tempVector = new Vector3();

        // Evaluate input & assign to vector
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            tempVector.x = 1.0f;
        else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
            tempVector.x = -1.0f;

        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            tempVector.z = 1.0f;
        else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
            tempVector.z = -1.0f;

        // Normalize Vector
        tempVector.Normalize();

        // Assign temp vector to variable
        playerInput.InputVector = tempVector;
        #endregion

        #region Jump Button
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerInput.JumpButtonPressed)
                jumpButtonState = JumpButtonState.Held;
            else jumpButtonState = JumpButtonState.Pressed;

            playerInput.JumpButtonPressed = true;
        }
        else
        {
            jumpButtonState = JumpButtonState.Off;

            playerInput.JumpButtonPressed = false;
        }
        #endregion
    }

    internal Vector3 GetInputVector()
    {
        // Return playerInput
        return playerInput.InputVector;
    }
    internal JumpButtonState GetJumpButton()
    {
        // Return custom enum
        return jumpButtonState;
    }
}
