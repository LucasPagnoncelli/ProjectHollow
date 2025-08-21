using UnityEngine;

public class PlayerAtaque : MonoBehaviour
{
    public Transform ataquePoint;
    public float ataqueRange = 0.5f;
    public LayerMask enemyLayers;
    private bool atacando;
    [SerializeField] private Animator anim;

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
        Boss boss = enemy.GetComponent<Boss>();
            if (inimigo != null)
            {
                inimigo.DanoNoInimigo(1);
            }
            if (boss != null)
            {
                boss.DanoNoInimigo(1);
            }
        }
        ataqueanim();
    }

    private void OnDrawGizmosSelected()
    {
        if (ataquePoint != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(ataquePoint.position, ataqueRange);
        }
    }
    void ataqueanim()
    {
        anim.SetTrigger("ataque");
    }
}
