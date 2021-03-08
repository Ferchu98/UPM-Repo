using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minijuego2_1 : MinijuegoBase
{
    public GameObject botonJ1;
    public GameObject botonJ2;
    public GameObject botonJ3;
    public GameObject botonJ4;
    public GameObject botonJ5;
    public GameObject botonJ6;

    public int comprobar;

    private void Start()
    {
        comprobar = 0;
    }

    IEnumerator Completar()
    {
        texto.text = fraseAcierto;
        aS.PlayOneShot(sonidoAcierto);
        yield return new WaitForSeconds(1f);
        mM.CompletarM2(puntosAcierto);
        minijuego.SetActive(false);
    }

    public void Fallo()
    {
        texto.text = fraseFallo;
        barra2.GetComponent<ProgressBar2>().Substract(puntosFallo / 100);
        aS.PlayOneShot(sonidoFallo);
    }

    public void Comprobar()
    {
        if (comprobar == 4)
        {
            StartCoroutine(Completar());
        }
        else
        {
            Fallo();
            botonJ1.gameObject.SetActive(true);
            botonJ2.gameObject.SetActive(true);
            botonJ3.gameObject.SetActive(true);
            botonJ4.gameObject.SetActive(true);
            botonJ5.gameObject.SetActive(true);
            botonJ6.gameObject.SetActive(true);
            comprobar = 0;
        }
    }

    public void ObjetoCorrecto()
    {
        comprobar++;
    }

    public void ObjetoIncorrecto()
    {
        comprobar--;
    }
}