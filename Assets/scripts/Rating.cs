using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rating : MonoBehaviour
{
   
    public Button s1, s2, s3, s4, s5;
    int bn = 0;
     
    public void Star1()
    {
        bn = 1;
        FindObjectOfType<Audiomanager>().Clicksound();
        Ratethegame();
    }
    public void Star2()
    {
        bn = 2;
        FindObjectOfType<Audiomanager>().Clicksound();
        Ratethegame();
    }
    public void Star3()
    {
        bn = 3;
        FindObjectOfType<Audiomanager>().Clicksound();
        Ratethegame();
    }
    public void Star4()
    {
        bn = 4;
        FindObjectOfType<Audiomanager>().Clicksound();
        Ratethegame();
    }
    public void Star5()
    {
        bn = 5;
        FindObjectOfType<Audiomanager>().Clicksound();
        Ratethegame();
    }
    public void Ratethegame()
    {
        if (bn >= 1)
        {
            s1.image.color = Color.white;
            if (bn >= 2)
            {
                s2.image.color = Color.white;
                if (bn >= 3)
                {
                    s3.image.color = Color.white;
                    Application.OpenURL("https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate");

                    if (bn >= 4)
                    {
                        s4.image.color = Color.white;
                        Application.OpenURL("https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate");

                        if (bn >= 5)
                        {
                            s5.image.color = Color.white;
                            Application.OpenURL("https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate");


                        }
                    }
                }
            }
        }
        FindObjectOfType<PrefRating>().Ratpanelclose(2);
    }
    public void RprefDest()
    {
        FindObjectOfType<PrefRating>().Ratpanelclose(1);
    }
}
