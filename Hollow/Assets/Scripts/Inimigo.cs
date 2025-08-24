using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int vidaAtual = 5;
    


    public float velocidade = 2f;
    private bool faceFlip =true ; // controle de virada
    private Rigidbody2D rb;
    public SpriteRenderer rend;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Mover();
    }

    private void Mover()
    {
        float direcao = faceFlip ? 1 : -1;
        rb.linearVelocity = new Vector2(direcao * velocidade, rb.linearVelocityY);
    }

    private void flipEnemy()
    {
        if (faceFlip)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else
            transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Player") || !collision.collider.CompareTag("Chao"))
        {
            faceFlip = !faceFlip;
            flipEnemy();
        }
    }


    public void DanoNoInimigo(int dano)
    {
        vidaAtual -= dano;
        MudaCor();
        
        
        if (vidaAtual <= 0)
        {
            Destroy(this.gameObject);
           
        }
    }
    void MudaCor()
    {
        rend.color = Color.red;

        Invoke("NormalizaCor", 0.5f); //tempo para voltar a cor normal
    }

    void NormalizaCor()
    {
        rend.color = Color.white;
    }
}
