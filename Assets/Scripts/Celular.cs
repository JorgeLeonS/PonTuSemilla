﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celular : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("OculusB2") || Input.GetButtonDown("OculusB4"))
        {
            ForestController.marcoCelular = true;
            gameObject.GetComponent<GlowOnSelect>().glowing = false;
        }
    }
}
