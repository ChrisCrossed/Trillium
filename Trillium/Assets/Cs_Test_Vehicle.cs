using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cs_Test_Vehicle : MonoBehaviour
{
    GameObject this_GameObject;
    Rigidbody this_Rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        this_GameObject = gameObject;
        this_Rigidbody = this_GameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Apply forward velocity
        Vector3 v3_Velocity = this_Rigidbody.velocity;
        v3_Velocity = transform.forward * 5f;
        this_Rigidbody.velocity = v3_Velocity;

        // Apply rotation
        Vector3 v3_EulerRotation = this_GameObject.transform.eulerAngles;
        v3_EulerRotation.y += 30f * Time.deltaTime;
        this_GameObject.transform.eulerAngles = v3_EulerRotation;
    }
}
