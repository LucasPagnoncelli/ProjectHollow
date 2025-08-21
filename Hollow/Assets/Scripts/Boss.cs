using UnityEngine;

public class Boss : MonoBehaviour
{
    public int vidaAtual = 5;
    public GameObject Porta;
    
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
