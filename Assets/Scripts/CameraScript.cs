using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject[] KameraUtama;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnLevelWasLoaded(int level)
    {
        // Delete Duplicate Camera
        KameraUtama = GameObject.FindGameObjectsWithTag("MainCamera");
        if (KameraUtama.Length > 1)
        {
            Destroy(KameraUtama[1]);
        }
    }
}
