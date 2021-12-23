using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarEnemy : MonoBehaviour
{
    public EnemyMovement Enemy;
    public GameObject nyawa1, nyawa2, nyawa3, nyawa4, nyawa5, nyawa6, nyawa7, nyawa8;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy.nyawaMusuh == 8)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(true);
            nyawa5.SetActive(true);
            nyawa6.SetActive(true);
            nyawa7.SetActive(true);
            nyawa8.SetActive(true);
        }
        else if (Enemy.nyawaMusuh == 7)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(true);
            nyawa5.SetActive(true);
            nyawa6.SetActive(true);
            nyawa7.SetActive(true);
            nyawa8.SetActive(false);
        }
        else if (Enemy.nyawaMusuh == 6)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(true);
            nyawa5.SetActive(true);
            nyawa6.SetActive(true);
            nyawa7.SetActive(false);
            nyawa8.SetActive(false);
        }
        else if (Enemy.nyawaMusuh == 5)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(true);
            nyawa5.SetActive(true);
            nyawa6.SetActive(false);
            nyawa7.SetActive(false);
            nyawa8.SetActive(false);
        }
        else if (Enemy.nyawaMusuh == 4)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(true);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
            nyawa7.SetActive(false);
            nyawa8.SetActive(false);
        }
        else if (Enemy.nyawaMusuh == 3)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(true);
            nyawa4.SetActive(false);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
            nyawa7.SetActive(false);
            nyawa8.SetActive(false);
        }
        else if (Enemy.nyawaMusuh == 2)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(true);
            nyawa3.SetActive(false);
            nyawa4.SetActive(false);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
            nyawa7.SetActive(false);
            nyawa8.SetActive(false);
        }
        else if (Enemy.nyawaMusuh == 1)
        {
            nyawa1.SetActive(true);
            nyawa2.SetActive(false);
            nyawa3.SetActive(false);
            nyawa4.SetActive(false);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
            nyawa7.SetActive(false);
            nyawa8.SetActive(false);
        }
        else if (Enemy.nyawaMusuh == 0)
        {
            nyawa1.SetActive(false);
            nyawa2.SetActive(false);
            nyawa3.SetActive(false);
            nyawa4.SetActive(false);
            nyawa5.SetActive(false);
            nyawa6.SetActive(false);
            nyawa7.SetActive(false);
            nyawa8.SetActive(false);
        }
    }
}
