using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Socialbuttons : MonoBehaviour
{
    private Animator sidebar;
    int s = 0;
    public GameObject thanks;
    public GameObject tpanel;

    private void Start()
    {
        sidebar = GetComponent<Animator>();
       // sidebar.Play("social");
    }
    public void Socialbar()
    {
       
       // sidebar.Play("social");

    }
    public void Sidebar()
    {
        if (s==0)
        {
            FindObjectOfType<Bakcbtnmenu>().Bbtn(5);
            sidebar.Play("sidebar");
            s = 1;

        }else if (s == 1)
        {
            FindObjectOfType<Bakcbtnmenu>().Bbtn(0);
            sidebar.Play("sidebarclose");
            s = 0;
        }

    }
    public void Fb()
    {
        Application.OpenURL("https://www.facebook.com/alphasmart.online/?modal=admin_todo_tour");
    }
    public void Tweet()
    {
        Application.OpenURL("https://twitter.com/AlphaSmart5");
    }
    public void Youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCrfd9ArUbYQWxwSCJVFqb6Q?view_as=subscriber");
    }
    public void Web()
    {
        Application.OpenURL("https://www.alphasols.in.net");
    }
    public void Thnks()
    {
        tpanel.SetActive(true);
        thanks.SetActive(true);
        PlayerPrefs.Save();
        Invoke("Afterbuy", 5f);
    }
    void Afterbuy()
    {
        SceneManager.LoadScene("Menu");
    }

}
