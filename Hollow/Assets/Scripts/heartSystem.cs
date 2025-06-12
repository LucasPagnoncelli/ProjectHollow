using UnityEngine;
using UnityEngine.UI;

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

            if{
                coracao[i].enabled = true;
            }
            else
            {
                coracao[i].enabled = false;
            }
        }
    }
}
