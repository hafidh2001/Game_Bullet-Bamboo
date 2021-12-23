using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCredit : MonoBehaviour
{
    // Inisiasi Variabel
    public GameObject Credit;
    public bool Credit_Aktif;

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
        Credit.SetActive(Credit_Aktif);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
