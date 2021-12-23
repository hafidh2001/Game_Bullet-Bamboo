using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play_Sound : MonoBehaviour
{
    // Audio
    public AudioSource sound;

    // public GameObject[] sound_icon;

    // Audio
    public Slider volume_sound;

    // Start is called before the first frame update
    void Start()
    {
        // DontDestroyOnLoad(gameObject);
    }

    void OnMouseDown()
    {
        sound.Play();
        sound.volume = volume_sound.value;
    }

    // Update is called once per frame
    void Update()
    {

    }


    // void OnLevelWasLoaded(int level)
    // {
    //     // Delete Duplicate MC
    //     sound_icon = GameObject.FindGameObjectsWithTag("Sound");
    //     if (sound_icon.Length > 1)
    //     {
    //         Destroy(sound_icon[1]);
    //     }
    // }
}
