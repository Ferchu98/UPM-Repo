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
        StartCoroutine(Load());
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(escena);
    }

}
