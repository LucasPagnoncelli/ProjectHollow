using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class heartSystem : MonoBehaviour
{
    public int vidaAtual;
    public AudioSource somdano;
    public Image[] coracao;
    public Sprite cheio;
    public Sprite vazio;
    public SpriteRenderer rend;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        vidaAtual = Gamemaneger.instance.Vida;
    }

    // Update is called once per frame
    void Update()
    {
        HealthLogic();
       
    }

    void HealthLogic()
    {
        for (int i = 0; i < coracao.Length; i++)
        {

            if (vidaAtual > i)
            {
                coracao[i].enabled = true;
            }
            else
            {
                coracao[i].enabled = false;
                deathState();
            }
        }
    }

    void deathState()
    {
        if (vidaAtual <= 0)
        {
            SceneManager.LoadScene("GameOver");


        }
    }
    public void dano()
    {
        MudaCor();
        somdano.Play();
        Gamemaneger.instance.perdervida();
        
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