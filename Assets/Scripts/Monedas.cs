using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    public Monedas_recolectadas m;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            m.Monedas_agarradas++;
            Destroy(gameObject);
        }
    }
}
