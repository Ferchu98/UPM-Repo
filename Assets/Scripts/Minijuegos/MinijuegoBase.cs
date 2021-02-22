using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinijuegoBase : MonoBehaviour
{

    public MangerMinijuegos mM;

    public float puntosCompletar;

    //Añadir a cada minijuego un script especifico que herede de este, y reasignar on click de los botones correspondientes.

    public void Awake()
    {
        mM = GameObject.FindWithTag("ManagerMinijuegos").GetComponent<MangerMinijuegos>();
    }

    public void CompletarM1()
    {
        mM.CompletarM1(puntosCompletar);
    }

    public void CompletarM2()
    {
        mM.CompletarM2(puntosCompletar);
    }
}
