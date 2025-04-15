using System.Collections;
using System.Collections.Generic;   
using UnityEngine;


public class Movimentojogador : MonoBehaviour
{
    public float velocidadedojogador;
    public float alturadopulo;


    public Rigidbody2D origidbody2D;
    public SpriteRenderer ospriterenderer;
    public bool estanochao;
    public Transform verificadorDeChao;
    public float raiodeverificacao;
    public LayerMask layerchao;


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
        pular();
    }

    public void movimentojogador()
    {
        float inputdomovimento = Input.GetAxisRaw("Horizontal");
        origidbody2D.linearVelocity = new Vector2(inputdomovimento * velocidadedojogador, origidbody2D.linearVelocity.y);

        if(inputdomovimento > 0)
        {
            ospriterenderer.flipX = false;
        }
        if(inputdomovimento < 0)
        {
            ospriterenderer.flipX = true;
        }

    }

   
    public void pular()
    {
        estanochao = Physics2D.OverlapCircle(verificadorDeChao.position, raiodeverificacao, layerchao);

        if (Input.GetKeyDown(KeyCode.W) && estanochao == true)
        {
            origidbody2D.velocity  = Vector2.up * alturadopulo;
        }

    }
}
