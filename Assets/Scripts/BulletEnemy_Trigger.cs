using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy_Trigger : MonoBehaviour
{
    PlayerInfo MainCharacter;

    // Start is called before the first frame update
    void Start()
    {
        MainCharacter = GameObject.Find("Player").GetComponent<PlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            // Destroy(MainCharacter.gameObject); // MainCharacter dead
            MainCharacter.nyawa = MainCharacter.nyawa - 1;
            MainCharacter.isDead = true;
        }
    }
}
