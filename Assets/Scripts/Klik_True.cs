using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klik_True : MonoBehaviour
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
        btnPlay.SetActive(true);
        btnSettings.SetActive(true);
        btnCredit.SetActive(true);
        btnQuit.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
