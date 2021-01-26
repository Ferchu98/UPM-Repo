using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class Tarea1_1 : MonoBehaviour
{
    public GameObject parent;

    public GameObject tarea1_1;

    public GameObject barra;
    public float puntos;

    // Start is called before the first frame update
    void Start()
    {
        tarea1_1.SetActive(false);
        barra = GameObject.FindWithTag("Prof1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activar()
    {
        tarea1_1.SetActive(true);
        parent.SetActive(false);
    }
    
    public void Desactivar()
    {
        tarea1_1.SetActive(false);
        parent.SetActive(true);
    }

    public void Completar()
    {
        StartCoroutine(Completion());        
    }

    IEnumerator Completion()
    {
        barra.gameObject.GetComponent<ProgressBar1>().Increment(puntos);
        yield return new WaitForSeconds(0.5f);
        tarea1_1.SetActive(false);
        parent.SetActive(true);
    }
}
