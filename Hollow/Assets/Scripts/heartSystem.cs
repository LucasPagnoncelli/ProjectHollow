using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class heartSystem : MonoBehaviour
{
    public int vidaAtual;
    public Image[] coracao;
    public Sprite cheio;
    public Sprite vazio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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

            if (vidaAtual > i){
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
    public void dano() => Gamemaneger.instance.perdervida();
}
