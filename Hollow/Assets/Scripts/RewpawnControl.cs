using UnityEngine;

public class RewpawnControl : MonoBehaviour
{
    public static RewpawnControl Instance;

    public Transform respawn;

    private void Awake()
    {
        Instance = this;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.position = respawn.position;
        }
    }
}
