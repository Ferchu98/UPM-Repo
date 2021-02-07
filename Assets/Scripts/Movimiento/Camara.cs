using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject fundido;


    private void Start()
    {
        fundido.SetActive(false);
    }

    public void Mover(Transform destino)
    {
        StartCoroutine(MoverRutina(destino));
    }

    IEnumerator MoverRutina(Transform destino_)
    {
        //Fundido a negro
        fundido.SetActive(true);
        gameObject.transform.position = new Vector3 (destino_.position.x,destino_.position.y, -10);
        yield return new WaitForSeconds(0.5f);
        //Fundido de negro
        fundido.SetActive(false);

    }


}
