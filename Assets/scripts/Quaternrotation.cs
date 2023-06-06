using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaternrotation : MonoBehaviour
{
  
    bool turnleft = false;
    bool turnright = false;
    float time=0;

    private void Start()
    {
        MeshRenderer Playershad = this.GetComponent<MeshRenderer>();
        Playershad.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
    }

    private void Update()
    {

        if (turnright == true)
        {
            time += 1 * Time.deltaTime;
            this.transform.RotateAround(this.transform.position, this.transform.up, 90f * Time.deltaTime);
            //Debug.Log(time);
            if (time >= 1f)
            {
                turnright = false;
                FindObjectOfType<Joystickbuttons>().Isturning();
                time = 0;
        //Debug.Log("hie is7");
            }
        }

        if (turnleft == true)
        {
            time += 1 * Time.deltaTime;
            this.transform.RotateAround(this.transform.position, this.transform.up, -90f * Time.deltaTime);
           // Debug.Log(time);
            if (time >= 1f)
            {
                turnleft = false;
                FindObjectOfType<Joystickbuttons>().Isturning();
                time = 0;
        //Debug.Log("hie is6");
            }


        }


    }
    public void Leftturn()
    {
        turnleft = true;
       // Debug.Log("hie is4");
    }
    public void Rightturn()
    {
        turnright = true;
      //  Debug.Log("hie is5");
    }


}
