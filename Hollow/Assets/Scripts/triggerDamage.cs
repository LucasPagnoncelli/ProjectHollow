using UnityEngine;

public class triggerDamage : MonoBehaviour
{
    public heartSystem heartSystem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            heartSystem.vidaAtual--;
            heartSystem.dano();
        }
    }
}