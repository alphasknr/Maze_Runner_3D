using UnityEngine;
using UnityEngine.UI;

public class Gamesounds : MonoBehaviour
{
   
   
    public void Backbtn()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
    }
   public void Backtomenu()
    {
        FindObjectOfType<Audiomanager>().Clicksound();
    }

    
}
