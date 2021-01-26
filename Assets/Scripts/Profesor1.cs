using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Profesor1 : MonoBehaviour
{

    public GameObject tarea1;
    public GameObject tarea2;
    public Image retrato;

    public bool activo;

    // Start is called before the first frame update
    void Start()
    {
        retrato.gameObject.SetActive(false);
        tarea1.SetActive(false);
        tarea2.SetActive(false);
        activo = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTasks()
    {
        if (!activo)
        {
            retrato.gameObject.SetActive(true);
            tarea1.SetActive(true);
            tarea2.SetActive(true);
            activo = true;
        }
        else
        {
            retrato.gameObject.SetActive(false);
            tarea1.SetActive(false);
            tarea2.SetActive(false);
            activo = false;
        }
        
    }
}
