using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NotasManager : MonoBehaviour
{

    public Button comporbar;

    public string sceneFinal;

    public Slider barra1;
    public Slider barra2;

    public float nota1;
    public float nota2;

    public bool terminado;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        terminado = false;
    }

    // Update is called once per frame
    void Update()
    {
        nota1 = Mathf.Round(barra1.value * 10);
        nota2 = Mathf.Round(barra2.value * 10);

        if (nota1 >= 5 && nota2 >= 5 && !terminado)
        {
            comporbar.gameObject.SetActive(true);
        }
        else if (nota1 <= 5 && nota2 <= 5 && !terminado)
        {
            comporbar.gameObject.SetActive(false);
        }
    }

    public void Comprobar()
    {
        terminado = true;
        SceneManager.LoadScene(sceneFinal);
    }

    
}
