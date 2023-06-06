using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public GameObject resetbn;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public Button level7;
    public Button level8;
    public Button level9;
    public Button level10;
    public Button level11;
    public Button level12;
    public Button level13;
    public Button level14;
    public Button level15;
    public Button level16;
    public Button level17;
    public Button level18;
    public Button level19;
    public Button level20;
    public Button level21;
    public Button level22;
    public Button level23;
    public Button level24;
    public Button level25;
    public Button level26;
    public Button level27;
    public Button level28;
    public Button level29;
    public Button level30;
    int nl;
    readonly int lp = 0;
    private Image one;
    public GameObject skip;


    private void Awake()
    {
        PlayerPrefs.GetInt("level", 0);
        PlayerPrefs.GetInt("lp", 0);
    }


    private void Start()
    {
        
       // lp = PlayerPrefs.GetInt("lp");
        if (lp == 30)
        {
           // PlayerPrefs.SetInt("level", 30);
            //Levelbuttons();
        }else
        {
           // Levelbuttons();
        }

    }
    public void Levelbuttons()
    {
        nl = PlayerPrefs.GetInt("level");
        if (nl >= 2)
        {
            level2.interactable = true;

            if (nl >= 3)
            {
                level3.interactable = true;
                if (nl >= 4)
                {
                    level4.interactable = true;
                    if (nl >= 5)
                    {
                        level5.interactable = true;
                        if (nl >= 6)
                        {
                            level6.interactable = true;
                            if (nl >= 7)
                            {
                                level7.interactable = true;
                                if (nl >= 8)
                                {
                                    level8.interactable = true;
                                    if (nl >= 9)
                                    {
                                        level9.interactable = true;
                                        if (nl >= 10)
                                        {
                                            level10.interactable = true;
                                            if (nl >= 11)
                                            {
                                                level11.interactable = true;
                                                if (nl >= 12)
                                                {
                                                    level12.interactable = true;
                                                    if (nl >= 13)
                                                    {
                                                        level13.interactable = true;
                                                        if (nl >= 14)
                                                        {
                                                            level14.interactable = true;
                                                            if (nl >= 15)
                                                            {
                                                                level15.interactable = true;
                                                                if (nl >= 16)
                                                                {
                                                                    level16.interactable = true;
                                                                    if (nl >= 17)
                                                                    {
                                                                        level17.interactable = true;
                                                                        if (nl >= 18)
                                                                        {
                                                                            level18.interactable = true;
                                                                            if (nl >= 19)
                                                                            {
                                                                                level19.interactable = true;
                                                                                if (nl >= 20)
                                                                                {
                                                                                    level20.interactable = true;
                                                                                    if (nl >= 21)
                                                                                    {
                                                                                        level21.interactable = true;
                                                                                        if (nl >= 22)
                                                                                        {
                                                                                            level22.interactable = true;
                                                                                            if (nl >= 23)
                                                                                            {
                                                                                                level23.interactable = true;
                                                                                                if (nl >= 24)
                                                                                                {
                                                                                                    level24.interactable = true;
                                                                                                    if (nl >= 25)
                                                                                                    {
                                                                                                        level25.interactable = true;
                                                                                                        if (nl >= 26)
                                                                                                        {
                                                                                                            level26.interactable = true;
                                                                                                            if (nl >= 27)
                                                                                                            {
                                                                                                                level27.interactable = true;
                                                                                                                if (nl >= 28)
                                                                                                                {
                                                                                                                    level28.interactable = true;
                                                                                                                    if (nl >= 29)
                                                                                                                    {
                                                                                                                        level29.interactable = true;
                                                                                                                        skip.SetActive(false);
                                                                                                                        if (nl >= 30)
                                                                                                                        {
                                                                                                                            level30.interactable = true;
                                                                                                                            resetbn.SetActive(false);

                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }





        }
    }

  
   public void Level1()
   {
        SceneManager.LoadSceneAsync("Level1");
   }
   public void Level2()
   {
        SceneManager.LoadSceneAsync("Level2");
   }
   public void Level3()
   {
        SceneManager.LoadSceneAsync("Level3");
   }
    public void Level4()
    {
        SceneManager.LoadSceneAsync("Level4");
    }
    public void Level5()
    {
        SceneManager.LoadSceneAsync("Level5");
    }
    public void Level6()
    {
        SceneManager.LoadSceneAsync("Level6");
    }
    public void Level7()
    {
        SceneManager.LoadSceneAsync("Level7");
    }
    public void Level8()
    {
        SceneManager.LoadSceneAsync("Level8");
    }
    public void Level9()
    {
        SceneManager.LoadSceneAsync("Level9");
    }
    public void Level10()
    {
        SceneManager.LoadSceneAsync("Level10");
    }
    public void Level11()
    {
        SceneManager.LoadSceneAsync("Level11");
    }
    public void Level12()
    {
        SceneManager.LoadSceneAsync("Level12");
    }
    public void Level13()
    {
        SceneManager.LoadSceneAsync("Level13");
    }
    public void Level14()
    {
        SceneManager.LoadSceneAsync("Level14");
    }
    public void Level15()
    {
        SceneManager.LoadSceneAsync("Level15");
    }
    public void Level16()
    {
        SceneManager.LoadSceneAsync("Level16");
    }
    public void Level17()
    {
        SceneManager.LoadSceneAsync("Level17");
    }
    public void Level18()
    {
        SceneManager.LoadSceneAsync("Level18");
    }
    public void Level19()
    {
        SceneManager.LoadSceneAsync("Level19");
    }
    public void Level20()
    {
        SceneManager.LoadSceneAsync("Level20");
    }
    public void Level21()
    {
        SceneManager.LoadSceneAsync("Level21");
    }
    public void Level22()
    {
        SceneManager.LoadSceneAsync("Level22");
    }
    public void Level23()
    {
        SceneManager.LoadSceneAsync("Level23");
    }
    public void Level24()
    {
        SceneManager.LoadSceneAsync("Level24");
    }
    public void Level25()
    {
        SceneManager.LoadSceneAsync("Level25");
    }
    public void Level26()
    {
        SceneManager.LoadSceneAsync("Level26");
    }
    public void Level27()
    {
        SceneManager.LoadSceneAsync("Level27");
    }
    public void Level28()
    {
        SceneManager.LoadSceneAsync("Level28");
    }
    public void Level29()
    {
        SceneManager.LoadSceneAsync("Level29");
    }
    public void Level30()
    {
        SceneManager.LoadSceneAsync("Level30");
    }

}
