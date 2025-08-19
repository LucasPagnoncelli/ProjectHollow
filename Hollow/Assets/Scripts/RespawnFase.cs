using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnFase : MonoBehaviour
{
    public static RewpawnControl Instance;

    public Transform respawnfase;
    public GameObject Spawn;
    public int fase;


    void Start()
    {
        fase = Gamemaneger.instance.Fase2;

    }

    private void Awake()
    {
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && SceneManager.GetActiveScene().buildIndex == 2)
        {

            Gamemaneger.instance.voltar();
            fase++;
        }
        else if (collision.CompareTag("Player") && fase > 0)

        {
            collision.transform.position = respawnfase.position;
            Destroy(Spawn);
        }


    }

}
