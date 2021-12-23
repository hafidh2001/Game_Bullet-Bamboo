using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPeluru : MonoBehaviour
{
    PlayerShoot MainCharacter;
    public GameObject peluru1, peluru2, peluru3, peluru4, peluru5, peluru6, peluru7, peluru8, peluru9, peluru10, peluru11, peluru12, peluru13, peluru14, peluru15;

    // Start is called before the first frame update
    void Start()
    {
        MainCharacter = GameObject.Find("Player").GetComponent<PlayerShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MainCharacter.total_peluru == 15)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(true);
            peluru9.SetActive(true);
            peluru10.SetActive(true);
            peluru11.SetActive(true);
            peluru12.SetActive(true);
            peluru13.SetActive(true);
            peluru14.SetActive(true);
            peluru15.SetActive(true);
        }
        else if (MainCharacter.total_peluru == 14)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(true);
            peluru9.SetActive(true);
            peluru10.SetActive(true);
            peluru11.SetActive(true);
            peluru12.SetActive(true);
            peluru13.SetActive(true);
            peluru14.SetActive(true);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 13)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(true);
            peluru9.SetActive(true);
            peluru10.SetActive(true);
            peluru11.SetActive(true);
            peluru12.SetActive(true);
            peluru13.SetActive(true);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 12)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(true);
            peluru9.SetActive(true);
            peluru10.SetActive(true);
            peluru11.SetActive(true);
            peluru12.SetActive(true);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 11)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(true);
            peluru9.SetActive(true);
            peluru10.SetActive(true);
            peluru11.SetActive(true);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 10)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(true);
            peluru9.SetActive(true);
            peluru10.SetActive(true);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 9)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(true);
            peluru9.SetActive(true);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 8)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(true);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 7)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(true);
            peluru8.SetActive(false);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 6)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(true);
            peluru7.SetActive(false);
            peluru8.SetActive(false);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 5)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(true);
            peluru6.SetActive(false);
            peluru7.SetActive(false);
            peluru8.SetActive(false);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 4)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(true);
            peluru5.SetActive(false);
            peluru6.SetActive(false);
            peluru7.SetActive(false);
            peluru8.SetActive(false);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 3)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(true);
            peluru4.SetActive(false);
            peluru5.SetActive(false);
            peluru6.SetActive(false);
            peluru7.SetActive(false);
            peluru8.SetActive(false);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 2)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(true);
            peluru3.SetActive(false);
            peluru4.SetActive(false);
            peluru5.SetActive(false);
            peluru6.SetActive(false);
            peluru7.SetActive(false);
            peluru8.SetActive(false);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 1)
        {
            peluru1.SetActive(true);
            peluru2.SetActive(false);
            peluru3.SetActive(false);
            peluru4.SetActive(false);
            peluru5.SetActive(false);
            peluru6.SetActive(false);
            peluru7.SetActive(false);
            peluru8.SetActive(false);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
        else if (MainCharacter.total_peluru == 0)
        {
            peluru1.SetActive(false);
            peluru2.SetActive(false);
            peluru3.SetActive(false);
            peluru4.SetActive(false);
            peluru5.SetActive(false);
            peluru6.SetActive(false);
            peluru7.SetActive(false);
            peluru8.SetActive(false);
            peluru9.SetActive(false);
            peluru10.SetActive(false);
            peluru11.SetActive(false);
            peluru12.SetActive(false);
            peluru13.SetActive(false);
            peluru14.SetActive(false);
            peluru15.SetActive(false);
        }
    }
}
