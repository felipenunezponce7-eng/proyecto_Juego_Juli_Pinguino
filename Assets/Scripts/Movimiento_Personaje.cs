using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Movimiento_Personaje : MonoBehaviour
{
    public Disparar disparacion;
    public float speed = 5f;
    public float jumpForce = 7f;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask groundLayer;

    public Rigidbody2D rb;
    public float horizontal;
    private bool isGrounded;
    public GameObject checkpointactual;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    void Update()
    {
        // Detectar suelo
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundRadius,
            groundLayer
        );
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    // BOTONES / EVENT TRIGGER
    public void MoveLeft()
    {
        horizontal = -1f;
        transform.localScale = new Vector3(-1, 1, 1);
        disparacion.direccion = -1;
    }

    public void MoveRight()
    {
        horizontal = 1f;
        transform.localScale = new Vector3(1,1,1);
        disparacion.direccion = 1;
    }

    public void StopHorizontal()
    {
        horizontal = 0f;
    }

    public void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            rb.gravityScale = 4f;
        }
    }

    public void disparar()
    {
        disparacion.Activo();

    }   
    public void reaparecer()
    {
        rb.transform.localPosition = checkpointactual.gameObject.transform.position;
    }
}


