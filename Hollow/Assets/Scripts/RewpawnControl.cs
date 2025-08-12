using UnityEngine;
using UnityEngine.SceneManagement;

public class RewpawnControl : MonoBehaviour
{
    public static RewpawnControl Instance;

    public Transform respawn;
    public Transform respawnfase;
    public Transform respawnfase3;
    public GameObject Porta;
    public int fase;
    public int fase3;

    void Start()
    {
        fase = Gamemaneger.instance.Fase2;
        fase3 = Gamemaneger.instance.Fase3;
    }

    private void Awake()
    {
        Instance = this;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && SceneManager.GetActiveScene().buildIndex == 2)
        {
            Gamemaneger.instance.voltar();
            fase++;
        }

        else if (collision.CompareTag("Player") && SceneManager.GetActiveScene().buildIndex == 3)
        {
            Gamemaneger.instance.voltar3();
            fase3++;
        }
        if (collision.CompareTag("Player") && fase > 0)

        {
            collision.transform.position = respawnfase.position;
        }
        if (collision.CompareTag("Player") && fase3 > 0)

        {
                collision.transform.position = respawnfase3.position;
                Destroy(Porta, 1.0f);
        } 

        else if (collision.CompareTag("Player"))
        {
            collision.transform.position = respawn.position;
        }
        
    }

}
