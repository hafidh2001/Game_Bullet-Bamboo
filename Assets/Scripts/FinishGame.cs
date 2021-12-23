using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    // PlayerMovement MainCharacter;
    // CanvasNyawa barNyawa;
    // CanvasPeluru barPeluru;

    // Start is called before the first frame update
    void Start()
    {
        // MainCharacter = GameObject.Find("Player").GetComponent<PlayerMovement>();

        // barNyawa = GameObject.Find("HealthBar").GetComponent<CanvasNyawa>();
        // barPeluru = GameObject.Find("BulletBar").GetComponent<CanvasPeluru>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            // Destroy(MainCharacter.gameObject);
            // Destroy(barNyawa.gameObject); // menghapus object
            // Destroy(barPeluru.gameObject); // menghapus object
        }
    }
}
