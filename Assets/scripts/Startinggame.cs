using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Startinggame : MonoBehaviour
{
    private Animator starting;

    // Start is called before the first frame update
    void Start()
    {
        starting = GetComponent<Animator>();
    }

    public void Panelstart()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
        FindObjectOfType<Pausemenu>().Startvalue();
        FindObjectOfType<Lvlcount>().Juststart();
        starting.enabled = true;
        starting.Play("atstart");
    }

    
}
