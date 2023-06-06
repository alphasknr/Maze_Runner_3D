using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class Pausemenu : MonoBehaviour
{
    public GameObject mapview;
    public GameObject ppanel;
    public GameObject mpanel;
    public GameObject picon;
    public GameObject jystick;


    public Button mapbtn;
    public Button pause;
    public Button cbtnp;
    public Button cbtnm;
    public Button next;
    public Button retryp;
    public Button pagain;
    public Button addtime;

    int st = 0;
   // int m = 0;
    int ads;
    int bbtn = 0;
    int samead;


    private void Awake()
    {
        PlayerPrefs.GetInt("ads", 0);
    }

    void Start()
    {
        FindObjectOfType<Audiomanager>().Musicplay();
        ads = PlayerPrefs.GetInt("ads");
        Debug.Log("the ads removal code is " + ads);
        mapbtn.onClick.AddListener(Mapclick);
        pause.onClick.AddListener(Pauseclick);
        cbtnp.onClick.AddListener(Cbtnpclick);
        cbtnm.onClick.AddListener(Cbtnmclick);
        retryp.onClick.AddListener(Retrybutton);
        pagain.onClick.AddListener(Retrybutton);
        next.onClick.AddListener(Nextlevel);
        addtime.onClick.AddListener(Addingtime);
        
    }
    public void Addingtime()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        FindObjectOfType<Admobads>().Hidebanner();
        FindObjectOfType<Admobads>().UserOptToWatchAd1();
    }
    private void Cbtnmclick()
    {
        FindObjectOfType<Admobads>().Hidebanner();
        mpanel.SetActive(true);
        picon.SetActive(true);
        jystick.SetActive(true);
        mapview.SetActive(false);
        bbtn = 0;
    }

    private void Cbtnpclick()
    {
        FindObjectOfType<Admobads>().Hidebanner();
        mpanel.SetActive(true);
        picon.SetActive(true);
        jystick.SetActive(true);
        ppanel.SetActive(false);
        bbtn = 0;
    }

    private void Pauseclick()
    {
        Pausebutton();
        FindObjectOfType<Admobads>().Showbanner();
        mpanel.SetActive(false);
        picon.SetActive(false);
        jystick.SetActive(false);
        ppanel.SetActive(true);
        bbtn = 2;
    }

    private void Mapclick()
    {
        FindObjectOfType<Admobads>().Showbanner();
        mpanel.SetActive(false);
        picon.SetActive(false);
        jystick.SetActive(false);
        mapview.SetActive(true);
        bbtn = 3;
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (st == 1)
            {
                if (bbtn == 0)
                {
                    //  Debug.Log("back buttn pressed now");
                    pause.onClick.Invoke();
                }
                else if (bbtn == 2)
                {
                    cbtnp.onClick.Invoke();
                }
                else if (bbtn == 3)
                {
                    cbtnm.onClick.Invoke();
                }
            }
            
        }
       

    }

    public void Startvalue()
    {
        st = 1;
    }

    public void Menubutton()
    {
        PlayerPrefs.Save();
        FindObjectOfType<Audiomanager>().Clicksound();
        FindObjectOfType<Admobads>().Hidebanner();
        PlayerPrefs.SetInt("bmenu", 1);
        SceneManager.LoadScene("Menu");
        
    }
    
    public void Retrybutton()
    {
        samead = UnityEngine.Random.Range(4, 6);
        Debug.Log(samead);
        FindObjectOfType<Admobads>().Hidebanner();
        if (ads != 3)
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            if (samead == 5)
            {
                FindObjectOfType<Admobads>().GameOver();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
           

        }
        else
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1.0f;
        }
        
    }
    public void Pausebutton()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        Pausethegame();
        Time.timeScale = 0;
        jystick.SetActive(false);
        bbtn = 2;
    }
    public void Pausethegame()
    {
        Time.timeScale = 0.0f;
    }

    public void Contbutton()
    {
        Time.timeScale = 1;
        FindObjectOfType<Audiomanager>().Clicksound();
        //Debug.Log(Time.timeScale);
        jystick.SetActive(true);
       // bbtn = 0;
       
        
    }
    public void Resume()
    {
        Time.timeScale = 1;
        
    }
    
    public void Nextlevel()
    {
        samead = UnityEngine.Random.Range(2, 4);
        if (ads != 3)
        {
                FindObjectOfType<Audiomanager>().Clicksound();
                Debug.Log("the value is " + samead);
            if (samead == 3)
            {
                FindObjectOfType<Admobads>().GameOver();
                Nxtlvlafterad();
            }
            else
            {
                Nxtlvlafterad();
            }
           // FindObjectOfType<Admobads>().Hidebanner();

        }
        else
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            Nxtlvlafterad();
        }
        
    }
    public void Nxtlvlafterad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Mapbutton()
    {
        jystick.SetActive(false);
        mapview.SetActive(true);
        bbtn = 3;
        
    }
    public void Mclear()
    {
       // m = 0;
    }
    public void Mapvisible()
    {
        mapview.SetActive(true);
    }
    

}
