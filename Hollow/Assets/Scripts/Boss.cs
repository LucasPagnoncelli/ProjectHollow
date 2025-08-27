using UnityEngine;

public class Boss : MonoBehaviour
{
    public int vidaAtual = 5;
    public GameObject Porta;
    public SpriteRenderer rend;

    private bool isdead = false;
    public Rigidbody2D bullet;
    public Transform SpawnShot;
    public float minYforce, MaxYforce;
    public float minrate, maxrate;

    public GameObject espinhos;
    public Transform espinhosSpawn;
    public float minTime, maxTime;

    public void DanoNoInimigo(int dano)
    {
        vidaAtual -= dano;
        MudaCor();
        if(vidaAtual <= 0)
        {
            Destroy(this.gameObject);
            Destroy(Porta);
            
            Bullet[] bullets = FindObjectsOfType<Bullet>();        
            foreach (Bullet bullet in bullets)
            {
                bullet.gameObject.SetActive(false);
            }
        }
    }
    void MudaCor()
    {
        rend.color = Color.red;

        Invoke("NormalizaCor", 0.2f); //tempo para voltar a cor normal
    }

    void NormalizaCor()
    {
        rend.color = Color.white;
    }

    void Fire()
    {
        if (!isdead)
        {
            Rigidbody2D tempBulet = Instantiate(bullet, SpawnShot.position, Quaternion.identity);
            tempBulet.AddForce(new Vector2(-2, Random.Range(minYforce, MaxYforce)), ForceMode2D.Impulse);
            Invoke("Fire", Random.Range(minrate, maxrate));
        }
    }

    void Espinhos()
    {
        if (!isdead)
        {
            Instantiate(espinhos, espinhosSpawn.position, espinhosSpawn.rotation);
            Invoke("Espinhos", Random.Range(minTime, maxTime));
        }

    }

    public void activetboss()
    {
        Invoke("Fire", Random.Range(minrate, maxrate));
        Invoke("Espinhos", Random.Range(minTime, maxTime));
    }

    private void Start()
    {
        activetboss();
    }

}
