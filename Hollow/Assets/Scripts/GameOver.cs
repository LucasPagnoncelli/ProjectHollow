using UnityEngine;
using System.Collections;
using System.Collections.Concurrent;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private string nomeDoleveldojogo;
    [SerializeField] private string nomeDoleveldojogo2;
    [SerializeField] private GameObject painelmenuinicial;

    public void Renascer()
    {
        SceneManager.LoadScene(nomeDoleveldojogo);
    }
    
    public void sairjogo()
    {
        Debug.Log("Sair do jogo");
        SceneManager.LoadScene(nomeDoleveldojogo2);
    }
}
