using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOption : MonoBehaviour
{
    // Inisiasi Variabel
    public GameObject Settings;
    public bool Settings_Aktif;

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

        Settings.SetActive(Settings_Aktif);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
