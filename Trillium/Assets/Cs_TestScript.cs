﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cs_TestScript : MonoBehaviour
{
    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if ( timer > 3.0f )
        {
            timer = 0f;

            print(this.transform.position);
        }
    }
}
