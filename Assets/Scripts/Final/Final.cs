using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public Text nota1;
    public Text nota2;

    public NotasManager nManager;

    void Awake()
    {
        nManager = GameObject.FindWithTag("NotasManager").GetComponent<NotasManager>();
    }

    // Update is called once per frame
    void Update()
    {
        nota1.text = ("Nota de materiales: " + nManager.nota1.ToString() + "/10");
        nota2.text = ("Nota de maquetas: " + nManager.nota2.ToString() + "/10");

    }
}
