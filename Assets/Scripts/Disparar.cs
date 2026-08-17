using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Movimiento_Personaje persona;
    public GameObject municion;
    public Transform vector;
    public float velocidadbala;
    public float direccion = 1;
    
    private void Update()
    {
        
    }
    public void Activo()
    {
       GameObject bala = Instantiate(municion, vector);
       bala.SetActive(true);
        if (direccion == 1)
        {
            bala.GetComponent<Rigidbody2D>().velocity = velocidadbala * vector.right;
        }
        if (direccion == -1)
        {
            bala.GetComponent<Rigidbody2D>().velocity = velocidadbala * vector.right * -1;
        }



        Destroy(bala, 10f);
    }
}
