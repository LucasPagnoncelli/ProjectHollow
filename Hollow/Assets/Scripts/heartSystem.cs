using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class heartSystem : MonoBehaviour
{
    public int vidaAtual;
    public int vidaMaxima;

    public Image[] coracao;
    public Sprite cheio;
    public Sprite vazio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            Destroy(gameObject, 0.05f);
            SceneManager.LoadScene("Menu");

        }
    }
}
