using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bulletenemy, enemystartbullet;
    public float fireRate;
    float nextFire;

    public AudioSource soundShoot;

    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            soundShoot.Play();
            Instantiate(bulletenemy, enemystartbullet.transform.position, enemystartbullet.transform.rotation);
            nextFire = Time.time + fireRate;
        }
    }
}
