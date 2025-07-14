using UnityEngine;

public class PlayerAtaque : MonoBehaviour
{
    public Transform ataquePoint;
    public float ataqueRange = 0.5f;
    public LayerMask enemyLayers;
    private bool atacando;

    void Update()
    {
        atacando = Input.GetKeyDown(KeyCode.Z);
        if (atacando)
        {
            Ataque();
        }
    }

    void Ataque()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(ataquePoint.position, ataqueRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            Inimigo inimigo = enemy.GetComponent<Inimigo>();
            if (inimigo != null)
            {
                inimigo.DanoNoInimigo(1);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (ataquePoint != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(ataquePoint.position, ataqueRange);
        }
    }
}
