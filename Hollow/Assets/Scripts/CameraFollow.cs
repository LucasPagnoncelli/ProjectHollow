using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform protagonista;
    

    private void FixedUpdate()
    {
        transform.position = protagonista.transform.position + new Vector3(0,1,-10);
    }
}
