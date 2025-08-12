using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemaneger : MonoBehaviour
{
    public static Gamemaneger instance;

    private int vida = 4;
    private int fase2 = 0;
    private int fase3 = 0;

    public void voltar()
    {
        
    fase2++;
        
    }
    public void voltar3()
    {

        fase3++;

    }
    public int Vida
    {
        get
        {
            return vida;
        }
    }
    public int Fase2
    {
        get
        {
            return fase2;
        }
    }
    public int Fase3
    {
        get
        {
            return fase3;
        }
    }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void perdervida()
    {
        vida--;
        if(vida == 0)
        {
            vida = 4;
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
