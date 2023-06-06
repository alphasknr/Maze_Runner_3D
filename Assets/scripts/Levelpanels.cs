using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Levelpanels : MonoBehaviour
{
    private int levelpanel = 0;
    public GameObject levelspanel1;
    public GameObject levelspanel2;
    public GameObject levelspanel3;
    public GameObject levelspanel4;
    public GameObject levelspanel5;
    public GameObject levelspanel6;
    public Button prevbutton;
    public Button nextbutton;
    private Animator lvlanim;
   // readonly int lp;

    private void Awake()
    {
       // PlayerPrefs.GetInt("level", 0);
    }


    private void Start()
    {
       lvlanim = GetComponent<Animator>();
       ////lp = PlayerPrefs.GetInt("level");

       // if (levelpanel == 1)
       // {
       //     prevbutton.interactable=false;
       // }
       // if (levelpanel == 6)
       // {
       //     nextbutton.interactable = false;
       // }
       // if (lp>5 && lp < 11)
       // {
       //     levelpanel = 1;
       //     Next();

       // }else if (lp > 10 && lp < 16)
       // {
       //     levelpanel = 2;
       //     Next();

       // }else if (lp > 15 && lp < 21)
       // {
       //     levelpanel = 3;
       //     Next();

       // }else if (lp >20 && lp < 26)
       // {
       //     levelpanel = 4;
       //     Next();

       // }else if (lp > 25 && lp < 31)
       // {
       //     levelpanel = 5;
       //     Next();
       // }


    }




    public void Next()
    {
        FindObjectOfType<Audiomanager>().Clicksound();

        if (levelpanel == 1)
        {
            prevbutton.interactable = true;
            levelspanel1.SetActive(false);
            levelspanel2.SetActive(true);
            levelspanel3.SetActive(false);
            levelspanel4.SetActive(false);
            levelspanel5.SetActive(false);
            levelspanel6.SetActive(false);
            lvlanim.Play("levelpanel2");
            levelpanel = 2;

        }else if (levelpanel == 2)
        {
            prevbutton.interactable = true;
            levelspanel1.SetActive(false);
            levelspanel2.SetActive(false);
            levelspanel3.SetActive(true);
            levelspanel4.SetActive(false);
            levelspanel5.SetActive(false);
            levelspanel6.SetActive(false);
            lvlanim.Play("levelpanel3");
            levelpanel = 3;

        }
        else if (levelpanel == 3)
        {

            prevbutton.interactable = true;
            levelspanel1.SetActive(false);
            levelspanel2.SetActive(false);
            levelspanel3.SetActive(false);
            levelspanel4.SetActive(true);
            levelspanel5.SetActive(false);
            levelspanel6.SetActive(false);
            lvlanim.Play("levelpanel4");
            levelpanel = 4;

        }
        else if (levelpanel == 4)
        {

            prevbutton.interactable = true;
            levelspanel1.SetActive(false);
            levelspanel2.SetActive(false);
            levelspanel3.SetActive(false);
            levelspanel4.SetActive(false);
            levelspanel5.SetActive(true);
            levelspanel6.SetActive(false);
            lvlanim.Play("levelpanel5");
            levelpanel = 5;

        }
        else if (levelpanel == 5)
        {

            prevbutton.interactable = true;
            levelspanel1.SetActive(false);
            levelspanel2.SetActive(false);
            levelspanel3.SetActive(false);
            levelspanel4.SetActive(false);
            levelspanel5.SetActive(false);
            levelspanel6.SetActive(true);
            lvlanim.Play("levelpanel6");
            levelpanel = 6;
            nextbutton.interactable = false;
        }


    }

    public void Prev()
    {
        FindObjectOfType<Audiomanager>().Clicksound();

        if (levelpanel == 2)
        {
            levelspanel2.SetActive(false);
            levelspanel1.SetActive(true);
            lvlanim.Play("levelpanel1");
            levelpanel = 1;
            prevbutton.interactable = false;
           
        }else if (levelpanel == 3)
        {
            levelspanel3.SetActive(false);
            levelspanel2.SetActive(true);
            lvlanim.Play("levelpanel2");
            levelpanel = 2;


        }
        else if (levelpanel == 4)
        {
            levelspanel4.SetActive(false);
            levelspanel3.SetActive(true);
            lvlanim.Play("levelpanel3");
            levelpanel = 3;


        }
        else if (levelpanel == 5)
        {
            levelspanel5.SetActive(false);
            levelspanel4.SetActive(true);
            lvlanim.Play("levelpanel4");
            levelpanel = 4;


        }
        else if (levelpanel == 6)
        {
            levelspanel6.SetActive(false);
            levelspanel5.SetActive(true);
            lvlanim.Play("levelpanel5");
            levelpanel = 5;
            nextbutton.interactable = true;


        }
    }
}
