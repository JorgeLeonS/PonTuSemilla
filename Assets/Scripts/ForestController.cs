using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestController : MonoBehaviour
{
    public static bool marcoCelular;
    public GameObject fuego;
    public GameObject celular;

    // Start is called before the first frame update
    void Start()
    {
        marcoCelular = false;

        //highlight celular inicialmente
        celular.GetComponent<GlowOnSelect>().glowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (marcoCelular)
        {
            apagaFuego();
        }
    }

    void apagaFuego()
    {
        Destroy(fuego, 2);
        marcoCelular = false;

        // pasa a la siguiente escena
         StartCoroutine(NewScene());
    }

    IEnumerator NewScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Basura");
    }
}
