using UnityEngine;
using System.Collections;
using System;

public class ShareAndRate : MonoBehaviour
{

    int lan;
    private string subject = "Share Maze Runner Ultimate";
    private string body = "\n I really loved this game. Hope you too like this game\n MAZE RUNNER ULTIMATE \n Dowload right now \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";

    private void Awake()
    {
        PlayerPrefs.GetInt("lan", 0);
    }

    //Start is called before the first frame update
    private void Start()
    {
        lan = PlayerPrefs.GetInt("lan");
        Sharetext(lan);

    }
    public void Sharetext(int lan)
    {
        if (lan == 0)
        {
            subject = "share maze runner ultimate 3d";
            body = "\n i really loved this game. hope you too like this game\n maze runner ultimate \n dowload right now \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 1)
        {
            subject = "labyrinthe coureur ultime 3d";
            body = "\n j'ai vraiment aimé ce jeu. j'espère que vous aussi aimez ce jeu \n labyrinthe runner ultime 3d \n à télécharger tout de suite \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 2)
        {
            subject = "laberinto corredor ultimate 3d";
            body = "\n realmente me encantó este juego. espero que también te guste este juego \n maze runner ultimate 3d \n descarga ahora \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 3)
        {
            subject = "лабиринт бегун ultimate 3d";
            body = "\n очень любил эту игру. надеюсь, вам тоже понравится эта игра \n maze runner ultimate 3d \n скачать прямо сейчас \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 4)
        {
            subject = "labirinto corredor final 3d";
            body = "\n eu realmente amei este jogo. espero que você também goste deste jogo \n download labirinto final em 3d \n faça o download agora \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 5)
        {
            subject = "labyrinth läufer ultimative 3d";
            body = "\n ich habe dieses spiel wirklich geliebt. hoffe, dir gefällt dieses spiel auch \n maze runner ultimate \n lade es jetzt herunter \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 6)
        {
            subject = "المتاهة عداء 3d النهائي";
            body = "\n أحببت هذه اللعبة حقًا. آمل أن تكونوا معجبين بهذه اللعبة \n تنزيل المتاهة النهائية ثلاثية الأبعاد \n الآن" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 7)
        {
            subject = "迷路ランナー究極の3d";
            body = "\n このゲームは本当に気に入りました。あなたもこのゲームが好きだと思います \n 迷路ランナー究極の3d \n 今すぐダウンロード\n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 8)
        {
            subject = "迷宮賽跑者終極3d";
            body = "\n 我真的很喜歡這個遊戲。希望您也喜歡這個遊戲 \n 迷宮賽跑者終極3d \n 立即下載 \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
        if (lan == 9)
        {
            subject = "미로 러너 궁극적 인 3d";
            body = "\n이 게임을 정말 좋아했습니다. 이 게임이 마음에 드시기를 바랍니다. \n 미로 러너 궁극의 3d \n 지금 다운로드하십시오 \n" + "https://play.google.com/store/apps/details?id=com.alphaang.maze_ultimate";
        }
    }


    public void OnAndroidTextSharingClick()
    {

        StartCoroutine(ShareAndroidText());

    }
    public IEnumerator ShareAndroidText()
    {
        yield return new WaitForEndOfFrame();
        //execute the below lines if being run on a Android device

        //Reference of AndroidJavaClass class for intent
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        //Reference of AndroidJavaObject class for intent
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        //call setAction method of the Intent object created
        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        //set the type of sharing that is happening
        intentObject.Call<AndroidJavaObject>("setType", "text/plain");
        //add data to be passed to the other activity i.e., the data to be sent
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
        //intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TITLE"), "Text Sharing ");
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), body);
        //get the current activity
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        //start the activity by sending the intent data
        
        AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "Share Via");
        currentActivity.Call("startActivity", jChooser);

    }



}
