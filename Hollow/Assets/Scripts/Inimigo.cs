using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private int vidaAtual = 3;
    
    public void DanoNoInimigo(int dano)
    {
        vidaAtual -= dano;
        if(vidaAtual <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
