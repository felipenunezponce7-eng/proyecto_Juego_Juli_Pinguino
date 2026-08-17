using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zonademuerte : MonoBehaviour
{
    public Movimiento_Personaje m;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            m.reaparecer();
        }
    }
}
