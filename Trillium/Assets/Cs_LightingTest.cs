using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cs_LightingTest : MonoBehaviour
{
    
    Vector3 v3_LightingVector;


    // Start is called before the first frame update
    void Start()
    {
        v3_LightingVector = this.transform.localEulerAngles;

        print(v3_LightingVector);
    }

    // Update is called once per frame
    void Update()
    {
        v3_LightingVector.x += Time.deltaTime * 5f;
        if (v3_LightingVector.x > 360f) v3_LightingVector.x -= 360f;
        Quaternion tempQuat = Quaternion.Euler(v3_LightingVector);
        this.transform.rotation = tempQuat;
    }
}
