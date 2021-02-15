using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string escena;

    public void CargarEscena()
    {
        SceneManager.LoadScene(escena);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
