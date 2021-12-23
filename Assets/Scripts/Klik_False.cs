using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klik_False : MonoBehaviour
{
    public GameObject btnPlay, btnSettings, btnCredit, btnQuit;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {

    }

    void OnMouseUp()
    {
        btnPlay.SetActive(false);
        btnSettings.SetActive(false);
        btnCredit.SetActive(false);
        btnQuit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
