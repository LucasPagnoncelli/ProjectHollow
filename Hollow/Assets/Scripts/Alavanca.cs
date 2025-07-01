using UnityEditor.Rendering;
using UnityEngine;

public class Alavanca : MonoBehaviour
{
    public GameObject Porta; // Referência à porta
    public float rotationSpeed = 200f; // Velocidade de rotação da alavanca
    private bool isActivated = false;
    private bool playerInRange = false;
    public KeyCode interactionKey = KeyCode.E;

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(interactionKey))
        {
            ToggleLever();
            Debug.Log("Abriu porta");
            Destroy(Porta, 1.0f);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player está no alcance da alavanca");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player saiu do alcance da alavanca");
        }
    }

    private void ToggleLever()
    {
        isActivated = !isActivated;
        // Rotaciona a alavanca ao interagir
        if (isActivated)
        {
            
            //LeanTween.rotateZ(gameObject, transform.eulerAngles.z + 90f, 0.5f); // Rotação da alavanca usando LeanTween
        }
        else
        {
            //LeanTween.rotateZ(gameObject, transform.eulerAngles.z - 90f, 0.5f); // Rotação da alavanca ao desativar
        }

        //Chama a função para abrir ou fechar a porta
        Porta doorController = Porta.GetComponent<Porta>();
        if (doorController != null)
        {
            doorController.ToggleDoor();
            
        }
    }
}