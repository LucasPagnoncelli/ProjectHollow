using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class passardefase : MonoBehaviour
{
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



        }
    }
}
