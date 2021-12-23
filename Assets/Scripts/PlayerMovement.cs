using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float kecepatan = 5f; // movement left-right

    // animation
    Animator animasi;

    // movement
    private bool moveRight;
    private bool moveLeft;
    private bool moveJump;
    private bool moveCrouched;

    // movement jump
    public float jumpVelocity;
    public float jumpWaitTime;
    private float jumpWaitTimer;
    Rigidbody2D lompat;


    // flip-face
    public bool balik;
    public int pindah;


    // check ground
    public LayerMask ground;
    public Collider2D footCollider;
    public bool isGrounded;


    // Audio
    public AudioSource soundJump;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Diam"); // Test Movement Awal

        animasi = GetComponent<Animator>();
        lompat = GetComponent<Rigidbody2D>();
    }





    // Update is called once per frame
    void Update()
    {
        // Check Ground
        isGrounded = footCollider.IsTouchingLayers(ground);

        // Movement Control
        moveRight = Input.GetKey(KeyCode.D);
        moveLeft = Input.GetKey(KeyCode.A);
        moveJump = Input.GetKey(KeyCode.W);
        moveCrouched = Input.GetKey(KeyCode.S);

        // Timer Grounded
        if (isGrounded == true)
        {
            jumpWaitTimer = jumpWaitTime;
        }
        else
        {
            if (jumpWaitTimer > 0f)
            {
                jumpWaitTimer -= Time.deltaTime;
            }
        }

        // Check Default Animation
        if (isGrounded == false)
        {
            animasi.SetBool("Jump", true);
        }
        else
        {
            animasi.SetBool("Jump", false);
            animasi.SetBool("Crouched", false);
        }

        // Movement Left Right
        if (moveRight && !moveCrouched)
        {
            Debug.Log("Jalan ke Kanan"); // Test Movement

            animasi.SetBool("Run", true);
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
            pindah = 1;
        }
        else if ((moveLeft) && !moveCrouched)
        {
            Debug.Log("Jalan ke Kiri"); // Test Movement

            animasi.SetBool("Run", true);
            transform.Translate(Vector2.left * kecepatan * Time.deltaTime);
            pindah = -1;
        }
        else
        {
            animasi.SetBool("Run", false);
        }

        // Movement Jump
        if (moveJump && (isGrounded == true || jumpWaitTimer > 0f))
        {
            Debug.Log("Player Lompat"); // Test Lompat

            soundJump.Play();
            lompat.velocity = new Vector2(lompat.velocity.x, jumpVelocity * Time.fixedDeltaTime);
        }
        else if (moveCrouched && isGrounded == true)
        {
            Debug.Log("Player Menunduk"); // Test Crouched

            animasi.SetBool("Crouched", true);
        }

        // Flip
        if (pindah < 0 && !balik)
        {
            balikbadan();
        }
        else if (pindah > 0 && balik)
        {
            balikbadan();
        }

    }

    // Make method void flip
    void balikbadan()
    {
        balik = !balik;

        Vector3 person = transform.localScale;
        person.x = person.x * -1;

        transform.localScale = person;
    }
}
