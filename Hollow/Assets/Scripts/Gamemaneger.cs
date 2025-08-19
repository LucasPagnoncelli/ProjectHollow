using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemaneger : MonoBehaviour
{
    public static Gamemaneger instance;

    private int vida = 4;
    private int fase2 = 0;
    

    public void voltar()
    {
        
        fase2++;
        
        
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
        if(vida == 0 )
        {
            vida = 4;
        }
    }
    public void Reset()
    {
        vida = 4;
        fase2 = 0;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
