using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    public GameObject MainCharacter;
    Animator animasi;

    // check alive
    public int nyawa;
    public bool isDead = false;
    Vector2 pos;

    // skor
    public int skor;

    // canvas
    Text infoSkor;

    PlayerShoot Character;

    // Start is called before the first frame update
    void Start()
    {
        animasi = GetComponent<Animator>();

        // canvas
        infoSkor = GameObject.Find("UI-Skor").GetComponent<Text>();

        // Change Stage
        pos = GameObject.FindWithTag("StartPos").transform.position;

        Character = GameObject.Find("Player").GetComponent<PlayerShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check Status
        if (isDead == true)
        {
            transform.position = pos;
            isDead = false;

            if (Character.total_peluru != 0)
            {
                Character.total_peluru = Character.total_peluru - Character.total_peluru;
                Character.total_peluru = Character.total_peluru + 15;
            }
            else if (Character.total_peluru == 0)
            {
                Character.total_peluru = Character.total_peluru + 15;
            }
        }

        // canvas
        infoSkor.text = skor.ToString();

        if (nyawa <= 0)
        {
            animasi.SetBool("Jump", false);
            animasi.SetBool("Crouched", false);
            animasi.SetBool("Run", false);

            MainCharacter.GetComponent<PlayerMovement>().enabled = false;

            Destroy(gameObject); // menghapus object

            // Tampilkan GameOver
            SceneManager.LoadScene("GameOver");
        }
    }

}
