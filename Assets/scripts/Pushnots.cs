using UnityEngine;
using Unity.Notifications.Android;

public class Pushnots : MonoBehaviour
{
    string preday, day;

    private void Awake()
    {
        PlayerPrefs.GetString("pday");
    }

    private void Start()
    {
        preday = PlayerPrefs.GetString("pday");

        day = System.DateTime.Now.ToString("dd");
        PlayerPrefs.SetString("pday", day);
       // Debug.Log(preday);
        if (preday != day)
        {
         //Debug.Log(day);
            Createnotificationchannel();
            Sendnotification();
        }
        
        
    }
    void Createnotificationchannel()
    {
        var c = new AndroidNotificationChannel()
        {
         Id = "mazepn1",
         Name = "playreminder",
         Importance = Importance.High,
         Description = "Reminds the player to play the game",       
        };
        AndroidNotificationCenter.RegisterNotificationChannel(c);
    }
    void Sendnotification()
    {
        var notification = new AndroidNotification
        {
            Title = "Maze Runner Ultimate",
            Text = "Don't you wanna get out of the maze ?",
            FireTime = System.DateTime.Now.AddHours(8),
            LargeIcon = "icon_1"
        };
        AndroidNotificationCenter.SendNotification(notification, "mazepn1");
    }



}
