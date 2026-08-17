using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguirpersonaje : MonoBehaviour
{
   public Movimiento_Personaje personaje;
    void Update()
    {
        if (personaje.horizontal > 0 )
        {
            transform.position = personaje.transform.position + new Vector3( 1, -0.5f, 0);
        }
        if (personaje.horizontal < 0)
        {
            transform.position = personaje.transform.position + new Vector3(-1, -0.5f, 0);
        }


    }
}
