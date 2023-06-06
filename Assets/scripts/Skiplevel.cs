using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skiplevel : MonoBehaviour
{
    int y;
    //bool inlevel = true;
    public GameObject skippanel;


    private void Awake()
    {
        PlayerPrefs.GetInt("level", 0);
    }

    private void Start()
    {
        y = PlayerPrefs.GetInt("level");
      
    }

    //public void Resetlevels()
    //{
    //    if (inlevel)
    //    {
    //        PlayerPrefs.SetInt("level", 0);
    //        inlevel = false;
    //        y = PlayerPrefs.GetInt("level");

    //        Debug.Log(y);
    //    }
    //}


    public void Skip()
    {
        y = PlayerPrefs.GetInt("level");

        if ( y == 0)
        {
            PlayerPrefs.SetInt("level", 2);

        }
        else if ( y == 2)
        {
            PlayerPrefs.SetInt("level", 3);

        }
        else if (y == 3)
        {
            PlayerPrefs.SetInt("level", 4);

        }
        else if (y == 4)
        {
            PlayerPrefs.SetInt("level", 5);

        }
        else if (y == 5)
        {
            PlayerPrefs.SetInt("level", 6);

        }
        else if (y == 6)
        {
            PlayerPrefs.SetInt("level", 7);

        }
        else if (y == 7)
        {
            PlayerPrefs.SetInt("level", 8);

        }
        else if (y == 8)
        {
            PlayerPrefs.SetInt("level", 9);

        }
        else if (y == 9)
        {
            PlayerPrefs.SetInt("level", 10);

        }
        else if (y == 10)
        {
            PlayerPrefs.SetInt("level", 11);

        }
        else if (y == 11)
        {
            PlayerPrefs.SetInt("level", 12);

        }
        else if (y == 12)
        {
            PlayerPrefs.SetInt("level", 13);

        }
        else if (y == 13)
        {
            PlayerPrefs.SetInt("level", 14);

        }
        else if (y == 14)
        {
            PlayerPrefs.SetInt("level", 15);

        }
        else if (y == 15)
        {
            PlayerPrefs.SetInt("level", 16);

        }
        else if (y == 16)
        {
            PlayerPrefs.SetInt("level", 17);

        }
        else if (y == 17)
        {
            PlayerPrefs.SetInt("level", 18);

        }
        else if (y == 18)
        {
            PlayerPrefs.SetInt("level", 19);

        }
        else if (y == 19)
        {
            PlayerPrefs.SetInt("level", 20);

        }
        else if (y == 20)
        {
            PlayerPrefs.SetInt("level", 21);

        }
        else if (y == 21)
        {
            PlayerPrefs.SetInt("level", 22);

        }
        else if (y == 22)
        {
            PlayerPrefs.SetInt("level", 23);

        }
        else if (y == 23)
        {
            PlayerPrefs.SetInt("level", 24);

        }
        else if (y == 24)
        {
            PlayerPrefs.SetInt("level", 25);

        }
        else if (y == 25)
        {
            PlayerPrefs.SetInt("level", 26);

        }
        else if (y == 26)
        {
            PlayerPrefs.SetInt("level", 27);

        }
        else if (y == 27)
        {
            PlayerPrefs.SetInt("level", 28);

        }
        else if (y == 28)
        {
            PlayerPrefs.SetInt("level", 29);

        }
        else if (y == 29)
        {
            PlayerPrefs.SetInt("level", 30);

        }
        else if (y == 30)
        {
            PlayerPrefs.SetInt("level", 31);

        }
        FindObjectOfType<Levels>().Levelbuttons();
        Debug.Log(y);

    }

    public void Skiptoback()
    {
        FindObjectOfType<Bakcbtnmenu>().Bbtn(6);
    }
    public void Noskip()
    {
        skippanel.SetActive(false);
    }
}
