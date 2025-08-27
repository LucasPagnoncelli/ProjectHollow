using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10;

    public float destroyTime = 2;
    

    // Use this for initialization
    void Start()
    {
        
        Destroy(gameObject, destroyTime);

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         heartSystem heartSystem = collision.GetComponent<heartSystem>();

        if (collision.gameObject.tag == "Player")
        {
            heartSystem.vidaAtual--;
            heartSystem.dano();

            Destroy(this.gameObject);
        }
    }
}
