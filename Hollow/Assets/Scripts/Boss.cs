using UnityEngine;

public class Boss : MonoBehaviour
{
    public int vidaAtual = 5;
    public GameObject Porta;
    public SpriteRenderer rend;
    
    public void DanoNoInimigo(int dano)
    {
        vidaAtual -= dano;
        MudaCor();
        if(vidaAtual <= 0)
        {
            Destroy(this.gameObject);
            Destroy(Porta);
        }
    }
    void MudaCor()
    {
        rend.color = Color.red;

        Invoke("NormalizaCor", 0.2f); //tempo para voltar a cor normal
    }

    void NormalizaCor()
    {
        rend.color = Color.white;
    }
}
