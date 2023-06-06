using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;


public class Joystickbuttons : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    int walk = 0;
    int move = 0;
    bool turning = true;
    //public GameObject mimap;


    public void Start()
    {
       // Startwindow();
    }
    void Startwindow()
    {
        Time.timeScale = 0f;
    }
    public void Levelstart()
    {
        Time.timeScale = 1f;
        //FindObjectOfType<Admobads>().Hidebanner();
    }
   

    private void FixedUpdate()
    {
       
        if (move == 1 || Input.GetKeyDown("up"))
        {
            Fronton();
        }
        if (move == 2 || Input.GetKey("down"))
        {
            Backon();
        }
        if (move == 3|| Input.GetKey("left"))
        {
            Lefton();
        }
        if (move == 4 || Input.GetKey("right"))
        {
            Righton();
        }
        //Debug.Log(turning);
    }
    public void Righton()
    {
       
        rb.transform.Translate(speed * Time.deltaTime, 0, 0);
        move = 4;
        if (walk == 0)
        {
            FindObjectOfType<Audiomanager>().Footstep();
            walk = 1;
        }
    }
    
    public void Lefton()
    {
       
        rb.transform.Translate(-speed * Time.deltaTime, 0, 0);
        move = 3;
        if (walk == 0)
        {
            FindObjectOfType<Audiomanager>().Footstep();
            walk = 1;
        }

    }
    
    public void Fronton()
    {
        
        rb.transform.Translate(0, 0, speed * Time.deltaTime);
        move = 1;
        if (walk == 0)
        {
            FindObjectOfType<Audiomanager>().Footstep();
            walk = 1;
        }
    }
    
   
    public void Backon()
    {
        
        rb.transform.Translate(0, 0, -speed * Time.deltaTime);
        move = 2;
        if (walk == 0)
        {
            FindObjectOfType<Audiomanager>().Footstep();
            walk = 1;
        }
    }
    public void Stop()
    {
        move = 0;
        walk = 0;
        FindObjectOfType<Audiomanager>().Stopwalking();

    }
    public void Isturning()
    {
        turning = true;
       // Debug.Log("hie is rigginal");
    }
    public void Left()
    {
       // Debug.Log(turning);
        if (turning)
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            FindObjectOfType<Quaternrotation>().Leftturn();
            turning = false;
        //Debug.Log("hie is2");
        }
        // mimap.transform.RotateAround(mimap.transform.position, mimap.transform.forward, -90);
    }

    public void Right()
    {
       // Debug.Log(turning);
        if (turning)
        {
            FindObjectOfType<Audiomanager>().Clicksound();
            FindObjectOfType<Quaternrotation>().Rightturn();
            turning = false;
       // Debug.Log("hie is3");
        }
        //  mimap.transform.RotateAround(mimap.transform.position, mimap.transform.forward,90);
    }

}
