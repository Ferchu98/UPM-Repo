using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minijuego2_4 : MinijuegoBase
{
    public void Fallo()
    {
        texto.text = fraseFallo;
        barra2.GetComponent<ProgressBar2>().Substract(puntosFallo / 100);
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
        mM.CompletarM2(puntosAcierto);
        minijuego.SetActive(false);
    }



}
