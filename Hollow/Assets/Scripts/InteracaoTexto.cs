using UnityEngine;
using TMPro;

public class InteracaoTexto : MonoBehaviour
{
    public GameObject caixaDeTexto; // painel da UI
    public TextMeshProUGUI textoTMP; // texto dentro da caixa
    public string mensagem = "Olá"; // mensagem exibida

    private bool jogadorPerto = false;

    void Start()
    {
        caixaDeTexto.SetActive(false); // começa invisível
    }

    void Update()
    {
        if (jogadorPerto && Input.GetKeyDown(KeyCode.E))
        {
            bool ativo = !caixaDeTexto.activeSelf;
            caixaDeTexto.SetActive(ativo);

            if (ativo)
            {
                textoTMP.text = mensagem;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            jogadorPerto = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorPerto = false;
            caixaDeTexto.SetActive(false);
        }
    }
}
