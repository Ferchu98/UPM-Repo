using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class Tarea1_1 : MonoBehaviour
{
    public GameObject parent;

    public GameObject tarea1_1;

    public int pointsDB;


    public GameObject barra;

    public bool completada;

    // Start is called before the first frame update
    void Start()
    {
        tarea1_1.SetActive(false);
        barra = GameObject.FindWithTag("Prof1");
        completada = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activar()
    {
        if (!completada)
        {
            tarea1_1.SetActive(true);
            parent.SetActive(false);
        }
    }
    
    public void Desactivar()
    {
        tarea1_1.SetActive(false);
        parent.SetActive(true);
    }

    public void Completar(float points)
    {
        StartCoroutine(Completion(points));
        points = pointsDB;
    }

    IEnumerator Completion(float puntos)
    {
        barra.gameObject.GetComponent<ProgressBar1>().Increment(puntos/100);
        yield return new WaitForSeconds(2f);
        tarea1_1.SetActive(false);
        parent.SetActive(true);
        completada = true;
    }
}
