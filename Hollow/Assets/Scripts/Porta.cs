
using Unity.VisualScripting;
using UnityEngine;

public class Porta : MonoBehaviour
{
    //public float openAngle = -90f; // Ângulo de abertura da porta
   // public float closeAngle = 0f; // Ângulo de fechamento da porta
   // public float animationDuration = 1f; // Duração da animação
    private bool isOpen = false;
    private Collider2D colisao;

    // Função para abrir ou fechar a porta
    public void ToggleDoor()
    {
        isOpen = !isOpen;
        

        //float targetAngle = isOpen ? openAngle : closeAngle;
        //LeanTween.rotateLocal(gameObject, new Vector3(0, 0, targetAngle), animationDuration);
    }
}
