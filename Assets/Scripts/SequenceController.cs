using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceController : MonoBehaviour
{
    public static bool fuegoApagado, basuraRecogida, semillasAventadas;
    public GameObject fuego;

    // Start is called before the first frame update
    void Start()
    {
        fuegoApagado = false;
        basuraRecogida = false;
        semillasAventadas = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fuegoApagado) {
		apagaFuego();
	}
    }

    //
    void apagaFuego()
    {
        fuegoApagado = true;
        Destroy(fuego, 3);
    }

    void recogeBasura()
    {
        basuraRecogida = true;
    }

    void avientaSemillas()
    {
        semillasAventadas = true;
    }


}