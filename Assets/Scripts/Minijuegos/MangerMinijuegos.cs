using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MangerMinijuegos : MonoBehaviour
{

    public GameObject[] minijuegos1;
    public int activeM1;
    public ProgressBar1 pb1;

    public GameObject[] minijuegos2;
    public int activeM2;
    public ProgressBar2 pb2;


    private void Awake()
    {
        activeM1 = 0;
        activeM2 = 0;

        for (int i = 0; i < minijuegos1.Length; i++)
        {
            minijuegos1[i].SetActive(false);
        }
        for (int i = 0; i < minijuegos2.Length; i++)
        {
            minijuegos2[i].SetActive(false);
        }

        pb1 = GameObject.FindWithTag("Prof1").GetComponent<ProgressBar1>();
        pb2 = GameObject.FindWithTag("Prof2").GetComponent<ProgressBar2>();
    }

    private void Start()
    {
        minijuegos1[activeM1].SetActive(true);
        minijuegos2[activeM2].SetActive(true);

    }

    public void CompletarM1(float puntos)
    {
        minijuegos1[activeM1].SetActive(false);
        if (activeM1 < (minijuegos1.Length))
        {
            pb1.Increment(puntos / 100);
            if (activeM1 < (minijuegos1.Length - 1))
            {
                activeM1++;
                minijuegos1[activeM1].SetActive(true);
            }
        }
        
    }

    public void CompletarM2(float puntos)
    {
        minijuegos2[activeM2].SetActive(false);
        if (activeM2 < (minijuegos2.Length))
        {
            pb2.Increment(puntos / 100);
            if (activeM2 < (minijuegos2.Length - 1))
            {
                activeM2++;
                minijuegos2[activeM2].SetActive(true);
            }
        }
    }

}
