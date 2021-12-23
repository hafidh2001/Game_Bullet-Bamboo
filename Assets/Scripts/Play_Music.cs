using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play_Music : MonoBehaviour
{
    // Audio
    public AudioSource music;
    public GameObject[] music_icon;

    // Audio
    public Slider volume_music;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void OnMouseDown()
    {
        music.Play();
        music.volume = volume_music.value;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnLevelWasLoaded(int level)
    {
        // Delete Duplicate MC
        music_icon = GameObject.FindGameObjectsWithTag("Music");
        if (music_icon.Length > 1)
        {
            Destroy(music_icon[1]);
        }
    }
}
