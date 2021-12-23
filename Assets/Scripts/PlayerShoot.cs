using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public int total_peluru = 15;
    private bool key_shoot;
    private bool isShooting;
    public float shootSpeed, shootTimer;

    // shooting
    public GameObject bullet, startbullet;

    // Audio
    public AudioSource soundShoot;

    // Start is called before the first frame update
    void Start()
    {
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (total_peluru > 0)
        {
            key_shoot = Input.GetKey(KeyCode.R);

            // Movement Shooting
            if (key_shoot && !isShooting)
            {
                StartCoroutine(Shoot());
            }
        }
    }

    IEnumerator Shoot()
    {
        Debug.Log("Player Shoot"); // Test Shoot

        int direction()
        {
            if (transform.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        }

        isShooting = true;

        soundShoot.Play();

        GameObject newBullet = Instantiate(bullet, startbullet.transform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * direction() * Time.fixedDeltaTime, 0f);
        newBullet.transform.localScale = new Vector2(newBullet.transform.localScale.x * direction(), newBullet.transform.localScale.y);

        total_peluru = total_peluru - 1;

        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }
}
