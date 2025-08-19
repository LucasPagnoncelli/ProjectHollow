using UnityEngine;

public class triggerDamage : MonoBehaviour
{
    public heartSystem heartSystem;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            heartSystem.vidaAtual--;
            heartSystem.dano();
        }
    }
}