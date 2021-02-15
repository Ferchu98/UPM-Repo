using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NotasManager : MonoBehaviour
{

    public Button comprobar;

    public string sceneFinal;

    public Slider barra1;
    public Slider barra2;

    public float nota1;
    public float nota2;

    //public bool terminado;
    void Awake()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("NotasManager");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        barra1 = GameObject.FindWithTag("Prof1").gameObject.GetComponent<Slider>();
        barra2 = GameObject.FindWithTag("Prof2").gameObject.GetComponent<Slider>();
        comprobar = GameObject.FindWithTag("Comprobar").gameObject.GetComponent<Button>();
        //terminado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Escena 1")
        {
            nota1 = Mathf.Round(barra1.value * 10);
            nota2 = Mathf.Round(barra2.value * 10);

            if (nota1 >= 5 && nota2 >= 5)
            {
                comprobar.gameObject.SetActive(true);
            }
            else if (nota1 <= 5 && nota2 <= 5)
            {
                comprobar.gameObject.SetActive(false);
            }

        }

        
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (SceneManager.GetActiveScene().name == "Escena 1")
        {
            barra1 = GameObject.FindWithTag("Prof1").gameObject.GetComponent<Slider>();
            barra2 = GameObject.FindWithTag("Prof2").gameObject.GetComponent<Slider>();
            comprobar = GameObject.FindWithTag("Comprobar").gameObject.GetComponent<Button>();
        }
    }
    public void Comprobar()
    {
        //terminado = true;
        SceneManager.LoadScene(sceneFinal);
    }

    
}
