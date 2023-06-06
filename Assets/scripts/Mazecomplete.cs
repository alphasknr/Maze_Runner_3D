using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mazecomplete : MonoBehaviour
{
    public GameObject winmenu;
    public GameObject pausebtn;
    public GameObject mapbtn;
    public GameObject joysticks;
    public GameObject timer;
    int x;
    int y;
    List<int> ratenum = new List<int> { 4, 7, 10, 14, 15, 18, 22, 25, 26, 27, 28, 29, 30 };



    private void Awake()
    {
        PlayerPrefs.GetInt("level", 0);
    }

    private void Start()
    {
        x = SceneManager.GetActiveScene().buildIndex;
        y = PlayerPrefs.GetInt("level");
    }
    
    private void OnTriggerEnter()
    {
     // Debug.Log("you entered trigger mode ...");
        FindObjectOfType<Audiomanager>().Stopwalking();
        FindObjectOfType<Lvlcount>().Winfail();
        winmenu.SetActive(true);
        pausebtn.SetActive(false);
        mapbtn.SetActive(false);
        joysticks.SetActive(false);
        timer.SetActive(true);
       // FindObjectOfType<PrefRating>().Ratpanelopen();


        if (x == 1 && y == 0)
        {
            PlayerPrefs.SetInt("level", 2);
        }
        else if (x == 2 && y == 2)
        {
            PlayerPrefs.SetInt("level", 3);
        }
        else if (x == 3 && y == 3)
        {
            PlayerPrefs.SetInt("level", 4);
        }
        else if (x == 4 && y == 4)
        {
            PlayerPrefs.SetInt("level", 5);
        }
        else if (x == 5 && y == 5)
        {
            PlayerPrefs.SetInt("level", 6);
        }
        else if (x == 6 && y == 6)
        {
            PlayerPrefs.SetInt("level", 7);
        }
        else if (x == 7 && y == 7)
        {
            PlayerPrefs.SetInt("level", 8);
        }
        else if (x == 8 && y == 8)
        {
            PlayerPrefs.SetInt("level", 9);

        }else if (x == 9 && y == 9)
        {
            PlayerPrefs.SetInt("level", 10);

        }else if (x == 10 && y == 10)
        {
            PlayerPrefs.SetInt("level", 11);
        }
        else if (x == 11 && y == 11)
        {
            PlayerPrefs.SetInt("level", 12);

        }else if (x == 12 && y == 12)
        {
            PlayerPrefs.SetInt("level", 13);

        }else if (x == 13 && y == 13)
        {
            PlayerPrefs.SetInt("level", 14);
        }
        else if (x == 14 && y == 14)
        {
            PlayerPrefs.SetInt("level", 15);

        }else if (x == 15 && y == 15)
        {
            PlayerPrefs.SetInt("level", 16);
        }
        else if (x == 16 && y == 16)
        {
            PlayerPrefs.SetInt("level", 17);

        }else if (x == 17 && y == 17)
        {
            PlayerPrefs.SetInt("level", 18);

        }else if (x == 18 && y == 18)
        {
            PlayerPrefs.SetInt("level", 19);
        }
        else if (x == 19 && y == 19)
        {
            PlayerPrefs.SetInt("level", 20);

        }else if (x == 20 && y == 20)
        {
            PlayerPrefs.SetInt("level", 21);
        }
        else if (x == 21 && y == 21)
        {
            PlayerPrefs.SetInt("level", 22);

        }else if (x == 22 && y == 22)
        {
            PlayerPrefs.SetInt("level", 23);
        }
        else if (x == 23 && y == 23)
        {
            PlayerPrefs.SetInt("level", 24);

        }else if (x == 24 && y == 24)
        {
            PlayerPrefs.SetInt("level", 25);

        }else if (x == 25 && y == 25)
        {
            PlayerPrefs.SetInt("level", 26);
        }
        else if (x == 26 && y == 26)
        {
            PlayerPrefs.SetInt("level", 27);

        }else if (x == 27 && y == 27)
        {
            PlayerPrefs.SetInt("level", 28);
        }
        else if (x == 28 && y == 28)
        {
            PlayerPrefs.SetInt("level", 29);

        }else if (x == 29 && y == 29)
        {
            PlayerPrefs.SetInt("level", 30);
        }
        else if (x == 30 && y == 30)
        {
            PlayerPrefs.SetInt("level", 31);
        }

        if (ratenum.Contains(x))
        {
            FindObjectOfType<PrefRating>().Ratpanelopen();
        }

    }

}
