using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScriptMinijuego1 : MonoBehaviour
{

    public Text texto;

    public string[] textos;
    public int currentText;

    public GameObject minijuego;

    public bool empezar;
    public GameObject barra;
    public Tarea1_1 tarea;
    public int puntosFallo;
    public int puntosAcierto;

    public GameObject boton1;
    public GameObject boton2;


    void Awake()
    {
        currentText = 0;
        minijuego.SetActive(false);
        barra = GameObject.FindWithTag("Prof1");

    }

    void Update()
    {
        if (!empezar)
        {
            texto.text = textos[currentText];
        }
        else
        {
            boton1.SetActive(false);
            boton2.SetActive(false);
        }

    }

    public void Avanzar()
    {
        if (currentText < (textos.Length -1))
        {
            currentText++;
        }
        else if (currentText == (textos.Length - 1))
        {
            minijuego.SetActive(true);
            empezar = true;
        }
    }

    public void Retroceder()
    {
        if (currentText > 0)
        {
            currentText--;
        }
    }

    public void Fallo()
    {
        texto.text = "No creo que ese sea el material más adecuado.";
        barra.gameObject.GetComponent<ProgressBar1>().Substract(puntosFallo / 100);
    }

    public void Acierto()
    {
        texto.text = "Muchas gracias, ese es justo el material que estaba buscando.";
        tarea.Completar(puntosAcierto);
    }


}
