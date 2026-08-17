using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monedas_recolectadas : MonoBehaviour
{
    public int Monedas_agarradas;

    public void Update()
    {
        if (Monedas_agarradas >= 6)
        {
            Destroy(gameObject);
        }
    }
}
