using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    PlayerInfo MainCharacter;
    PlayerShoot Character;
    public GameObject triggerEnemy;
    public GameObject healthBar;
    public GameObject batasPeluru;

    // Nyawa Enemy
    public int nyawaMusuh;

    // Start is called before the first frame update
    void Start()
    {
        MainCharacter = GameObject.Find("Player").GetComponent<PlayerInfo>();
        Character = GameObject.Find("Player").GetComponent<PlayerShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nyawaMusuh <= 0)
        {
            triggerEnemy.SetActive(false);
            gameObject.SetActive(false);
            healthBar.SetActive(false);
            batasPeluru.SetActive(false);

            MainCharacter.skor = MainCharacter.skor + 100;

            Character.total_peluru = Character.total_peluru + 10;

            if (Character.total_peluru > 15)
            {
                Character.total_peluru = Character.total_peluru - Character.total_peluru;
                Character.total_peluru = Character.total_peluru + 15;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            MainCharacter.nyawa = MainCharacter.nyawa - 1;
            MainCharacter.isDead = true;
        }
        else if (other.transform.tag == "Bullet")
        {
            nyawaMusuh = nyawaMusuh - 1;
            MainCharacter.skor = MainCharacter.skor + 10;
        }
    }
}
