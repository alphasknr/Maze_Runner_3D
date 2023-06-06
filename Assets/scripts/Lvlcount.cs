using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvlcount : MonoBehaviour
{
    float presenttime = 0f;
    public float leveltime = 30f;
    public GameObject levelfail;
    public GameObject pausebtn;
    public GameObject mapbtn;
    public GameObject levelclock;
    public GameObject joystick;
    public Text levelcount;
    private bool start = false;
    public GameObject Rewithtime;
    int nt;


    private void Awake()
    {
        PlayerPrefs.GetInt("ads",0);

    }

    private void Start()
    {
        presenttime = leveltime;
        nt = PlayerPrefs.GetInt("ads");

    }


    void Update()
    {
        if (start == false)
        {
           // presenttime = temptime; ;
            levelcount.text = presenttime.ToString("0");
        }
        if (presenttime >= 0 && start == true)
        {
            presenttime -= 1 * Time.deltaTime;
            levelcount.text = presenttime.ToString("0");

            if (presenttime <= 10)
            {
                levelcount.color = Color.red;
            }

            if (presenttime <= 0)
            {
                levelfail.SetActive(true);
                pausebtn.SetActive(false);
                mapbtn.SetActive(false);
                joystick.SetActive(false);
                FindObjectOfType<Audiomanager>().Stopwalking();
                FindObjectOfType<Admobads>().Showbanner();
                Noadretime();
            }

        }


    }
    public void Noadretime()
    {
        if (nt == 3)
        {
            Rewithtime.SetActive(false);
        }
    }

    public void Juststart()
    {
        start = true;
    }
    public void Addtime()
    {
        leveltime = 15;
        presenttime = leveltime;
        start = true;
        levelfail.SetActive(false);
        pausebtn.SetActive(true);
        mapbtn.SetActive(true);
        levelclock.SetActive(true);
        joystick.SetActive(true);
        Debug.Log("added time is 15 seconds");
    }
    public void Winfail()
    {
        levelfail.SetActive(false);
        start = false;
    }
}
