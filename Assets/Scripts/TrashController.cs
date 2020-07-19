using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashController : MonoBehaviour
{
    public GameObject basureroOrganico, basureroInorganico;
    public GameObject[] trashArr;
	public static int trashCounter = 4;


    // Start is called before the first frame update
    void Start()
    {

        //highlight basura inicialmente
        foreach(GameObject trash in trashArr)
        {
            trash.GetComponent<GlowOnSelect>().glowing = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
	Debug.Log(trashCounter);
        if(trashCounter <= 0)
        {
            recogeBasura();
        }
    }

    void recogeBasura()
    {
        // pasa a la siguiente escena
	SceneManager.LoadScene("Semillas");
    }
}
