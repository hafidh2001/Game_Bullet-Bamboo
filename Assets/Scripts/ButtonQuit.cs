using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit : MonoBehaviour
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

    void OnMouseUp()
    {
        clickButton.Play();
        // Quit Game
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
