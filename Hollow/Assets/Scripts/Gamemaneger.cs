using UnityEngine;

public class Gamemaneger : MonoBehaviour
{
    public static Gamemaneger instance;

    private int vida = 4;


    public int Vida
    {
        get
        {
            return vida;
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
