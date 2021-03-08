using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minijuego1_1 : MinijuegoBase
{
    public void Fallo()
    {
        texto.text = fraseFallo;
        barra1.GetComponent<ProgressBar1>().Substract(puntosFallo / 100);
        aS.PlayOneShot(sonidoFallo);
    }

    public void Acierto()
    {
        StartCoroutine(Completar());
    }

    IEnumerator Completar()
    {
        texto.text = fraseAcierto;
        aS.PlayOneShot(sonidoAcierto);
        yield return new WaitForSeconds(1f);
        mM.CompletarM1(puntosAcierto);
        minijuego.SetActive(false);
    }



}
