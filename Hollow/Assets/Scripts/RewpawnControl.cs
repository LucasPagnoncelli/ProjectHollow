using UnityEngine;
using UnityEngine.SceneManagement;

public class RewpawnControl : MonoBehaviour
{
    public static RewpawnControl Instance;

    public Transform respawn;


    void Start()
    {
 
        
    }

    private void Awake()
    {
        Instance = this;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            collision.transform.position = respawn.position;
        }
        
    }

}
