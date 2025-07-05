using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentojogador : MonoBehaviour
{
    [Header("Movimentação")]
    public float velocidadedojogador = 5f;
    public float alturadopulo = 7f;

    [Header("Componentes")]
    public Rigidbody2D origidbody2D;
    public SpriteRenderer ospriterenderer;

    [Header("Verificação de Chão")]
    public Transform verificadorDeChao;
    public float raiodeverificacao = 0.2f;
    public LayerMask layerchao;

    private bool estanochao;
    private float inputHorizontal;
    private bool desejaPular;

    void Update()
    {
        // Captura do input de movimento
        inputHorizontal = Input.GetAxisRaw("Horizontal");

        // Captura do input de pulo usando tecla W
        if (Input.GetKeyDown(KeyCode.W))
        {
            desejaPular = true;
        }
    }

    void FixedUpdate()
    {
        VerificarChao();
        MovimentarJogador();
        Pular();
        desejaPular = false; // Reset da flag após aplicar
    }

    void MovimentarJogador()
    {
        origidbody2D.linearVelocity = new Vector2(inputHorizontal * velocidadedojogador, origidbody2D.linearVelocity.y);

        if (inputHorizontal > 0)
            ospriterenderer.flipX = false;
        else if (inputHorizontal < 0)
            ospriterenderer.flipX = true;
    }

    void VerificarChao()
    {
        estanochao = Physics2D.OverlapCircle(verificadorDeChao.position, raiodeverificacao, layerchao);
    }

    void Pular()
    {
        if (desejaPular && estanochao)
        {
            origidbody2D.linearVelocity = Vector2.up * alturadopulo;
        }
    }

    void OnDrawGizmosSelected()
    {
        if (verificadorDeChao != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(verificadorDeChao.position, raiodeverificacao);
        }
    }
}
