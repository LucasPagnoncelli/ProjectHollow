using UnityEngine;

public class Boss : MonoBehaviour
{
    private int vidaAtual = 5;
    private GameObject Porta;
    
    public void DanoNoInimigo(int dano)
    {
        vidaAtual -= dano;
        if(vidaAtual <= 0)
        {
            Destroy(this.gameObject);
            Destroy(Porta);
        }
    }
}
