using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonMovimiento : MonoBehaviour
{
    public Transform newPosition;

    public Camara camara;

    public void OnClick()
    {
        camara.Mover(newPosition);
    }

}
