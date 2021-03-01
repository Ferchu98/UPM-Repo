using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minijuego1_4 : MinijuegoBase
{

    public InputField respuesta;

    public string respuestaCorrecta;

    public void Comprobar()
    {
        if (respuesta.text == respuestaCorrecta)
        {
            StartCoroutine(Completar());
        }
        else
        {
            Fallo();
        }
    }

    IEnumerator Completar()
    {
        texto.text = fraseAcierto;
        yield return new WaitForSeconds(1f);
        mM.CompletarM1(puntosAcierto);
        minijuego.SetActive(false);
    }

    public void Fallo()
    {
        texto.text = fraseFallo;
        barra1.GetComponent<ProgressBar1>().Substract(puntosFallo / 100);
    }
}
