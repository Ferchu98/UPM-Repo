using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBoton : MonoBehaviour
{
    public AudioSource aS;
    public AudioClip sonido;

    public void Sonido()
    {
        aS.PlayOneShot(sonido);
    }
}
