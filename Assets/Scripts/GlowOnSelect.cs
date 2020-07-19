using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowOnSelect : MonoBehaviour
{
    public Material glowingMat;
    private Material originalMat;

    public bool glowing = false;

    // Start is called before the first frame update
    void Start()
    {
        originalMat = gameObject.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (glowing)
        {
            gameObject.GetComponent<Renderer>().material = glowingMat;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = originalMat;
        }

    }
}
