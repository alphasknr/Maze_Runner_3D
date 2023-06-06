using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;
   // public Vector3 offset;

    private void Update()
    {
        float hor = player.transform.position.x;
        float ver = player.transform.position.z;
        this.transform.position = new Vector3(hor, 135, ver);
    }

}
