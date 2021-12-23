using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    // Audio
    public AudioSource clickButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {
        clickButton.Play();
    }

    [System.Obsolete]
    void OnMouseUp()
    {
        // Go to scene : Stage-1
        Application.LoadLevel("SplashScreen");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
