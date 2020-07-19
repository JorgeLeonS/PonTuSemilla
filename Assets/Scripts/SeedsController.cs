using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedsController : MonoBehaviour
{
    public static bool semillasAventadas;
    public GameObject bolsaSemillas;
    public static int seedCounter = 3;
    public AudioSource a;

    // Start is called before the first frame update
    void Start()
    {
        
        semillasAventadas = false;
        //highlight semillas inicialmente
        bolsaSemillas.GetComponent<GlowOnSelect>().glowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (semillasAventadas)
        {
 		bolsaSemillas.GetComponent<GlowOnSelect>().glowing = false;
            plantaSemillas();
        }

        if(seedCounter <= 0)
        {
            Debug.Log("Finish");
            a.Play();
        }
    }

    void plantaSemillas()
    {

    }
}
