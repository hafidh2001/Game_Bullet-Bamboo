using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Player : MonoBehaviour
{
    float scale_mc;

    // flip-bullet
    public bool balik;
    public int pindah;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BatasPeluru") || collision.gameObject.CompareTag("Tanah") || collision.gameObject.CompareTag("BulletEnemy") || collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
