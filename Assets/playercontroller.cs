﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float ZSpeed;
    public float rotationspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //transform.Translate(0, 0, ZSpeed);
        //transform.Rotate(0, 0, ZSpeed);

        // if(transform.position.z < 4.5f)
        //{     transform.position += new Vector3(0, 0, ZSpeed); }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, ZSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -ZSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, rotationspeed, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, rotationspeed, 0);

        }
    }
}
