using UnityEngine;
using System.Collections;
using System.Collections.Concurrent;
using UnityEngine.SceneManagement;

public class MenuManeger : MonoBehaviour
{
    [SerializeField] private string nomeDoleveldojogo;
    [SerializeField] private GameObject painelmenuinicial;
    [SerializeField] private GameObject painelopcoes;
    public void jogar()
    {
        SceneManager.LoadScene(nomeDoleveldojogo);
    }
    public void abriropcoes()
    {
        painelmenuinicial.SetActive(false);
        painelopcoes.SetActive(true);
    }
    public void fecharopcoes()
    {
        painelopcoes.SetActive(false);
        painelmenuinicial.SetActive(true);
       
    }
    public void sairjogo()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
