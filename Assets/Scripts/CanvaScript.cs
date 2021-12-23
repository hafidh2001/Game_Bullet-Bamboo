using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvaScript : MonoBehaviour
{
    public GameObject[] Canvas;

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
        // Delete Duplicate Canvas
        Canvas = GameObject.FindGameObjectsWithTag("UI_Canvas");
        if (Canvas.Length > 1)
        {
            Destroy(Canvas[1]);
        }
    }
}
