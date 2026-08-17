using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour
{
   public  Movimiento_Personaje m;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            m.rb.gravityScale = 0.01f;
        }
    }
}
