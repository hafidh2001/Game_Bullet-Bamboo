using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Enemy_Kanan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(12f, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BatasPeluruEnemy") || collision.gameObject.CompareTag("Tanah") || collision.gameObject.CompareTag("Bullet") || collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
