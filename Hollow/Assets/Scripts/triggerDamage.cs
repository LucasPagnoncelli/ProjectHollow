using UnityEngine;

public class triggerDamage : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        heartSystem heartSystem = collision.GetComponent<heartSystem>();
        if (collision.gameObject.tag == "Player")
        {
            heartSystem.vidaAtual--;
            heartSystem.dano();
        }
    }
}