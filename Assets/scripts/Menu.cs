using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Animations;


public class Menu : MonoBehaviour
{
    public TMP_Text music;
    public TMP_Text sound;
    public Button buylevels;
    public Button removeads;
    public Button playone;
    public GameObject skipbtn;
    int x = 2;
    int y = 2;
    int b;
    int a;
    int l;
    int r;
    int lan;
    int bm;
    int sb;
    //public Animator amenu;
    public Animator asocial;
    bool begin = false;
   

    private void Awake()
    {
       
        PlayerPrefs.GetInt("sound", 0);
        PlayerPrefs.GetInt("music", 0);
        PlayerPrefs.GetInt("lan", 0);
        PlayerPrefs.GetInt("level", 0);
        PlayerPrefs.GetInt("ads", 0);
        PlayerPrefs.GetInt("bmenu", 0);
        PlayerPrefs.GetInt("skipbtn", 0);
        
    }


    private void Start()
    {
        lan = PlayerPrefs.GetInt("lan");
        FindObjectOfType<Menulocalization>().Languageselected(lan);
        a = PlayerPrefs.GetInt("music");
        b = PlayerPrefs.GetInt("sound");
        l = PlayerPrefs.GetInt("level");
        r = PlayerPrefs.GetInt("ads");
        bm = PlayerPrefs.GetInt("bmenu");
        sb = PlayerPrefs.GetInt("skipbtn");

        if (bm == 1)
        {
           
            playone.onClick.Invoke();
            PlayerPrefs.SetInt("bmenu", 0);
            begin = true;
        }
        

        Debug.Log(a);
        Debug.Log(b);
        if (a == 1)
        {
            music.color = Color.red;
            music.text = "X";
            FindObjectOfType<Audiomanager>().Musicon();
            y = 2;

        }
        else if (a == 2)
        {
            music.color = Color.green;
            music.text = "O";
            FindObjectOfType<Audiomanager>().Musicoff();
            y = 1;
        }
        if (b == 1)
        {
            sound.color = Color.red;
            sound.text = "X";
            FindObjectOfType<Audiomanager>().Sfxon();
            x = 2;
        }
        else if (b == 2)
        {
            sound.color = Color.green;
            sound.text = "O";
            FindObjectOfType<Audiomanager>().Sfxoff();
            x = 1;
        }

        FindObjectOfType<Audiomanager>().Musicplay();
        if (r == 3)
        {
            removeads.interactable = false;
        }
        if (l == 30)
        {
            buylevels.interactable = false;
        }
        if (!begin && bm == 0)
        {
            //StartCoroutine(Startanima(0.2f));
        }
    }

    private void Update()
    {
        
    }
    
    //public void Atstart()
    //{
    //    StartCoroutine(Startanima(0f));
    //}
    //IEnumerator Startanima(float wait)
    //{
    //    yield return new WaitForSeconds(wait);
    //    amenu.enabled = false;
    //    asocial.enabled = true;
    //}

    public void Sfxon()
    {
        if (x == 2)
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            sound.text = "O";
            sound.color = Color.green;
            PlayerPrefs.SetInt("sound", 2);
            FindObjectOfType<Audiomanager>().Sfxoff();
            //Debug.Log("sound =" + PlayerPrefs.GetInt("sound"));
            x = 1;
            
        }
        else if (x == 1)
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            sound.text = "X";
            sound.color = Color.red;
            PlayerPrefs.SetInt("sound", 1);
            FindObjectOfType<Audiomanager>().Sfxon();
            //Debug.Log("sound =" + PlayerPrefs.GetInt("sound"));
            x = 2;

        }


    }

    public void Mfxon()
    {
        if (y == 2)
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            music.text = "O";
            music.color = Color.green;
            PlayerPrefs.SetInt("music", 2);
            FindObjectOfType<Audiomanager>().Musicoff();
            //Debug.Log("music =" + PlayerPrefs.GetInt("music"));
            y = 1;
        }
        else if (y == 1)
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            music.text = "X";
            music.color = Color.red;
            PlayerPrefs.SetInt("music", 1);
            FindObjectOfType<Audiomanager>().Musicon();
           // Debug.Log("music =" + PlayerPrefs.GetInt("music"));
            y = 2;
        }

    }

    public void Playgame()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        FindObjectOfType<Bakcbtnmenu>().Bbtn(1);
        FindObjectOfType<PrefRating>().Ratpanel();
        if (sb == 1) 
        {
            skipbtn.SetActive(false);
        }else
        {
            skipbtn.SetActive(true);
        }
       // FindObjectOfType<Admobads>().Showbanner();
        
    }
    public void Quitgame()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        PlayerPrefs.Save();
        Application.Quit();
        //Debug.Log("QUIT");
        
    }
    public void Instructions()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        FindObjectOfType<Bakcbtnmenu>().Bbtn(3);
        //Debug.Log("instructions pressed now");
    }
    public void Options()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        FindObjectOfType<Bakcbtnmenu>().Bbtn(2);
        // Debug.Log("options pressed now");

    }
    public void More()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Alpha+Apps+%26+Games");
    }
    public void Privacy()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        Application.OpenURL("https://sites.google.com/view/alpha-apps-games-privacypolicy/home");
    }
    public void Reset()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Play()
    {
        FindObjectOfType<PrefRating>().Ratpanel();
    }
    public void Shopping()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        FindObjectOfType<Bakcbtnmenu>().Bbtn(4);

    }
    
}
