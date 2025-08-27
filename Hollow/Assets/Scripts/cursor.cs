using UnityEngine;

public class cursor : MonoBehaviour
{
    public bool fn = true;
    void Start()
    {
        Cursor.visible = fn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
