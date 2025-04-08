using System.Collections;
using System.Collections.Generic;   
using UnityEngine;


public class Movimentojogador : MonoBehaviour
{
    public float velocidadedojogador;
    public Rigidbody2D origidbody2D;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        movimentojogador();
    }
    public void movimentojogador()
    {
        float inputdomovimento = Input.GetAxisRaw("Horizontal");
        origidbody2D.linearVelocity = new Vector2(inputdomovimento * velocidadedojogador, origidbody2D.linearVelocity.y);

    }
}
