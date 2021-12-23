using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShootingEnemy : MonoBehaviour
{
    PlayerMovement MainCharacter;
    public LayerMask groundTrigger;
    public GameObject Enemy;
    public bool triggerActive;
    public bool triggerNonActive;

    public GameObject BarHealthMusuh;

    // Start is called before the first frame update
    void Start()
    {
        MainCharacter = GameObject.Find("Player").GetComponent<PlayerMovement>();

        // Script Non-aktif
        Enemy.GetComponent<EnemyShoot>().enabled = false;

        BarHealthMusuh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        triggerActive = MainCharacter.footCollider.IsTouchingLayers(groundTrigger);
        triggerNonActive = MainCharacter.footCollider.IsTouchingLayers(MainCharacter.ground);

        if (triggerActive == true)
        {
            Enemy.GetComponent<EnemyShoot>().enabled = true;
            BarHealthMusuh.SetActive(true);
        }
        else if (triggerNonActive == true)
        {
            Enemy.GetComponent<EnemyShoot>().enabled = false;
            BarHealthMusuh.SetActive(false);
        }
    }
}
