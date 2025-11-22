using UnityEngine;

public class Verificadordeinimigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject inimigo1;
    public GameObject inimigo2;
    public GameObject inimigo3;
    public GameObject inimigo4;
    public GameObject inimigo5;
    public GameObject Porta;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Verificar();
    }

    public void Verificar()
    {
        if(inimigo1 == null && inimigo2 == null && inimigo3 == null && inimigo4 == null && inimigo5 == null)
        {
            Destroy(Porta);
        }
    }
}
