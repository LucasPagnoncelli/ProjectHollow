
using Unity.VisualScripting;
using UnityEngine;

public class Porta : MonoBehaviour
{
    //public float openAngle = -90f; // �ngulo de abertura da porta
   // public float closeAngle = 0f; // �ngulo de fechamento da porta
   // public float animationDuration = 1f; // Dura��o da anima��o
    private bool isOpen = false;
    private Collider2D colisao;

    // Fun��o para abrir ou fechar a porta
    public void ToggleDoor()
    {
        isOpen = !isOpen;
        

        //float targetAngle = isOpen ? openAngle : closeAngle;
        //LeanTween.rotateLocal(gameObject, new Vector3(0, 0, targetAngle), animationDuration);
    }
}
