using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_PlayAgain : MonoBehaviour
{
    // Audio
    public AudioSource clickButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {

    }

    [System.Obsolete]
    void OnMouseUp()
    {
        clickButton.Play();

        // Go to scene : Stage-1
        Application.LoadLevel("Intro");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
