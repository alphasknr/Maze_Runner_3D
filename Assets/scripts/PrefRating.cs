using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefRating : MonoBehaviour
{
    public GameObject ratingpanel;
    GameObject rp;
    int  rat = 0;


    public void Ratpanelopen()
    {
        rp = Instantiate(ratingpanel, transform.parent) as GameObject;
     //Debug.Log("rating open");
        Ratpanelclose(0);
    }
    public void Ratpanelclose(int pr)
    {
        if (pr == 0) { Destroy(rp, 10f); }
        else if (pr == 1) { Destroy(rp, 0.1f); }
        else if (pr == 2) { Destroy(rp, 1f); }
    }

    public void Ratpanel()
    {
        rat += 1;
        if (rat == 3)
        {
            Ratpanelopen();
            rat = 0;
        }

    }
}
