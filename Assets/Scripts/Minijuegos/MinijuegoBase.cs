using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinijuegoBase : MonoBehaviour
{

    public MangerMinijuegos mM;

    public string fraseFallo;
    public string fraseAcierto;

    public GameObject barra1;
    public GameObject barra2;

    public GameObject minijuego;
    public GameObject puzle;

    public float puntosAcierto;
    public float puntosFallo;

    public Text texto;

    public string[] textos;
    public int currentText;
    public bool empezar;


    public GameObject botonAvanzar;
    public GameObject botonRetroceder;

    public GameObject botonMinijuego;

    //Añadir a cada minijuego un script especifico que herede de este, y reasignar on click de los botones correspondientes.

    public void Awake()
    {
        currentText = 0;
        minijuego.SetActive(false);
        mM = GameObject.FindWithTag("ManagerMinijuegos").GetComponent<MangerMinijuegos>();
        barra1 = GameObject.FindWithTag("Prof1");
        barra2 = GameObject.FindWithTag("Prof2");
    }

    void Update()
    {
        if (!empezar)
        {
            texto.text = textos[currentText];
        }
        else
        {
            botonAvanzar.SetActive(false);
            botonRetroceder.SetActive(false);
        }

    }


    public void Empezar()
    {
        minijuego.SetActive(true);
        botonMinijuego.SetActive(false);
        puzle.SetActive(false);
    }

    public void Avanzar()
    {
        if (currentText < (textos.Length - 1))
        {
            currentText++;
        }
        else if (currentText == (textos.Length - 1))
        {
            puzle.SetActive(true);
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
}
