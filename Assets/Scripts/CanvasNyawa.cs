using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasNyawa : MonoBehaviour
{
    PlayerInfo MainCharacter;
    public GameObject nyawa1, nyawa2, nyawa3, nyawa4, nyawa5, nyawa6;

    // Start is called before the first frame update
    void Start()
    {
        MainCharacter = GameObject.Find("Player").GetComponent<PlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MainCharacter.nyawa == 6)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(true);
            nyawa5.SetActive(true);
            nyawa6.SetActive(true);
        }
        else if (MainCharacter.nyawa == 5)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(true);
            nyawa5.SetActive(true);
            nyawa6.SetActive(false);
        }
        else if (MainCharacter.nyawa == 4)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(true);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
        }
        else if (MainCharacter.nyawa == 3)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(false);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
        }
        else if (MainCharacter.nyawa == 2)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(false);
            nyawa4.SetActive(false);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
        }
        else if (MainCharacter.nyawa == 1)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(false);
            nyawa3.SetActive(false);
            nyawa4.SetActive(false);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
        }
        else if (MainCharacter.nyawa == 0)
        {
            nyawa1.SetActive(false);
            nyawa2.SetActive(false);
            nyawa3.SetActive(false);
            nyawa4.SetActive(false);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
        }
    }
}
