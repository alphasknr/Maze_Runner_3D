using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bakcbtnmenu : MonoBehaviour
{
    int backbtn = 0;
    public Button bmenu;
    public Button setback;
    public Button inback;
    public Button shopback;
    public Button socialback;
    public Button skipback;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (backbtn == 0)
            {
                Application.Quit();
            }
            else if (backbtn == 1)
            {
                bmenu.onClick.Invoke();
            }
            else if (backbtn == 2)
            {
                setback.onClick.Invoke();
            }
            else if (backbtn == 3)
            {
                inback.onClick.Invoke();
            }
            else if (backbtn == 4)
            {
                shopback.onClick.Invoke();
            }
            else if (backbtn == 5)
            {
                socialback.onClick.Invoke();
            }
            else if (backbtn == 6)
            {
                skipback.onClick.Invoke();
                backbtn = 1;
            }
        }
    }
    
    public void Bbtn(int bvalue)
    {
        backbtn = bvalue;
    }

}
