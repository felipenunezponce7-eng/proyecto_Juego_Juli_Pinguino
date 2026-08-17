using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas2 : MonoBehaviour
{
    public int Monedas_agarradas;

    public void Update()
    {
        if (Monedas_agarradas >= 1)
        {
            Destroy(gameObject);
        }
    }
}
