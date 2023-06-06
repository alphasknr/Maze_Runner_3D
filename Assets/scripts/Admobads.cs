using System;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.Scripting;

public class Admobads : MonoBehaviour
{
    public GameObject warn;

    // Original ad Units //

    //readonly string appId = "ca-app-pub-5723481384418532~4775783026";
    //readonly string Banner = "ca-app-pub-5723481384418532/9159692658";
    //readonly string Interstitial = "ca-app-pub-5723481384418532/1060775001";
    //readonly string Rewardvideo = "ca-app-pub-5723481384418532/4438828958";
    //readonly string Interstitialagain = "ca-app-pub-5723481384418532/2480947045";
    //readonly string Rewardvideoagain = "ca-app-pub-5723481384418532/7351459330";


    //Test Ad units//

    readonly string Banner = "ca-app-pub-3940256099942544/6300978111";
    readonly string Rewardvideo = "ca-app-pub-3940256099942544/5224354917";
    readonly string Interstitial = "ca-app-pub-3940256099942544/1033173712";
    readonly string Interstitialagain = "ca-app-pub-3940256099942544/1033173712";
    readonly string Rewardvideoagain = "ca-app-pub-3940256099942544/5224354917";

    int ad = 0;
    int r;


    private BannerView bannerView;
    private InterstitialAd interstitialView;
    private InterstitialAd interstitialView2;
    private RewardBasedVideoAd rewardVideo;
    private RewardBasedVideoAd rewardVideo2;

    private void Awake()
    {
        PlayerPrefs.GetInt("ads", 0);
    }
    

    public void Start()
    {
        r = PlayerPrefs.GetInt("ads");

        if (r != 3)
        {

            // Initialize the Google Mobile Ads SDK.
            MobileAds.Initialize(initStatus => { });

            this.Requestbanner();

            this.RequestInterstitial();
            this.RequestInterstitial2();

            this.rewardVideo = RewardBasedVideoAd.Instance;

            // Called when an ad request has successfully loaded.
            rewardVideo.OnAdLoaded += HandleRewardBasedVideoLoaded;
            // Called when an ad request failed to load.
            rewardVideo.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
            // Called when an ad is shown.
            rewardVideo.OnAdOpening += HandleRewardBasedVideoOpened;
            // Called when the ad starts to play.
            rewardVideo.OnAdStarted += HandleRewardBasedVideoStarted;
            // Called when the user should be rewarded for watching a video.
            rewardVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;
            // Called when the ad is closed.
            rewardVideo.OnAdClosed += HandleRewardBasedVideoClosed;
            // Called when the ad click caused the user to leave the application.
            rewardVideo.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;

            this.Requestrewardvideo();

            this.rewardVideo2 = RewardBasedVideoAd.Instance;

            // Called when an ad request has successfully loaded.
            rewardVideo2.OnAdLoaded += HandleRewardBasedVideoLoaded2;
            // Called when an ad request failed to load.
            rewardVideo2.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad2;
            // Called when an ad is shown.
            rewardVideo2.OnAdOpening += HandleRewardBasedVideoOpened2;
            // Called when the ad starts to play.
            rewardVideo2.OnAdStarted += HandleRewardBasedVideoStarted2;
            // Called when the user should be rewarded for watching a video.
            rewardVideo2.OnAdRewarded += HandleRewardBasedVideoRewarded2;
            // Called when the ad is closed.
            rewardVideo2.OnAdClosed += HandleRewardBasedVideoClosed2;
            // Called when the ad click caused the user to leave the application.
            rewardVideo2.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication2;

            this.Requestrewardvideo2();

        }

        Hidebanner();
    }

   //.......................................................... BANNER AD  ...............................................


    void Requestbanner()
    {
        string bannerid = Banner;

        AdSize adSize = new AdSize(300, 250);
        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(bannerid, adSize, 5, 67);

        // Called when an ad request has successfully loaded.
        bannerView.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        bannerView.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is clicked.
        bannerView.OnAdOpening += HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        bannerView.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        bannerView.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        //// Create an empty ad request.
        //AdRequest request = new AdRequest.Builder().Build();

        //// Load the banner with the request.
        //bannerView.LoadAd(request);
    }

    public void Hidebanner()
    {
        if (r != 3)
        {
            bannerView.Hide();
         // Debug.Log("banner ad is hiding now ");
            //this.Requestbanner();

        }


    }

    public void Showbanner()
    {
        //warn.SetActive(true);

        if (r != 3)
        {
            // Create an empty ad request.
            AdRequest request = new AdRequest.Builder().Build();

            // Load the banner with the request.
            bannerView.LoadAd(request);
            bannerView.Show();
            Debug.Log("banner ad is showing now to the player in the win menu");
        }

           
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: " + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        bannerView.Destroy();
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }



    //........................................INTERSTITIAL AD ...................................................//


    void RequestInterstitial()
    {
        string interstitialid = Interstitial;

        this.interstitialView = new InterstitialAd(interstitialid);

        // Called when an ad request has successfully loaded.
        this.interstitialView.OnAdLoaded += IntHandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitialView.OnAdFailedToLoad += IntHandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitialView.OnAdOpening += IntHandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitialView.OnAdClosed += IntHandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.interstitialView.OnAdLeavingApplication += IntHandleOnAdLeavingApplication;


        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitialView.LoadAd(request);
    }
    void RequestInterstitial2()
    {
        string interstitialid2 = Interstitialagain;

        this.interstitialView2 = new InterstitialAd(interstitialid2);

        // Called when an ad request has successfully loaded.
        this.interstitialView2.OnAdLoaded += IntHandleOnAdLoaded2;
        // Called when an ad request failed to load.
        this.interstitialView2.OnAdFailedToLoad += IntHandleOnAdFailedToLoad2;
        // Called when an ad is shown.
        this.interstitialView2.OnAdOpening += IntHandleOnAdOpened2;
        // Called when the ad is closed.
        this.interstitialView2.OnAdClosed += IntHandleOnAdClosed2;
        // Called when the ad click caused the user to leave the application.
        this.interstitialView2.OnAdLeavingApplication += IntHandleOnAdLeavingApplication2;


        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitialView2.LoadAd(request);
    }
    public void GameOver()
    {
        if (r != 3)
        {
            if (this.interstitialView2.IsLoaded())
            {
                this.interstitialView2.Show();
                Debug.Log("original interstitial is showing now ");
            }
            else
            {
                ad = 2;
                this.interstitialView.Show();
            }
        }
    }
    public void Nextad()
    {
        if (r != 3)
        {
            if (this.interstitialView2.IsLoaded())
            {
                this.interstitialView2.Show();
            }
            else
            {
                FindObjectOfType<Pausemenu>().Nxtlvlafterad();
            }
        }
    }

    public void IntHandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("interstitial HandleAdLoaded event received");
    }

    public void IntHandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("interstitial HandleFailedToReceiveAd event received with message: " + args.Message);
    }

    public void IntHandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("interstitial HandleAdOpened event received");
    }

    public void IntHandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("interstitial HandleAdClosed event received");
        this.RequestInterstitial();
    }

    public void IntHandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("interstitial HandleAdLeavingApplication event received");
        interstitialView.Destroy();
    }

    public void IntHandleOnAdLoaded2(object sender, EventArgs args)
    {
        MonoBehaviour.print("interstitial HandleAdLoaded event received");
    }

    public void IntHandleOnAdFailedToLoad2(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("interstitial HandleFailedToReceiveAd event received with message: " + args.Message);
    }

    public void IntHandleOnAdOpened2(object sender, EventArgs args)
    {
        MonoBehaviour.print("interstitial HandleAdOpened event received");
    }

    public void IntHandleOnAdClosed2(object sender, EventArgs args)
    {
        MonoBehaviour.print("interstitial HandleAdClosed event received");
        this.RequestInterstitial2();
    }

    public void IntHandleOnAdLeavingApplication2(object sender, EventArgs args)
    {
        MonoBehaviour.print("interstitial HandleAdLeavingApplication event received");
        interstitialView2.Destroy();
    }



    //...................................................REWARD VIDEO AD 1 ............................................//


    void Requestrewardvideo()
    {
        string rewardId = Rewardvideo;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded video ad with the request.
        this.rewardVideo.LoadAd(request, rewardId);
        
    }
    public void UserOptToWatchAd()
    {
        if (r != 3)
        {
            // Skippingtest();
           // FindObjectOfType<Skiplevel>().Skip();
            if (rewardVideo.IsLoaded())
            {
                ad = 7;
                rewardVideo.Show();
                Debug.Log("reward video showing now");
            }
            else if (rewardVideo2.IsLoaded() && !rewardVideo.IsLoaded())
            {
                ad = 9;
                rewardVideo2.Show();
                Debug.Log("reward video 2 showing now");
            }
            else
            {
                warn.SetActive(true);
            }
        }

    }
    //public void Skippingtest()
    //{
    //    if (ad == 5)
    //    {
    //        FindObjectOfType<Lvlcount>().Addtime();
    //    }
    //    else if (ad == 10)
    //    {
    //        FindObjectOfType<Skiplevel>().Skip();
    //    }
    //}
    public void UserOptToWatchAd1()
    {
        if (r != 3)
        {
            //warn.SetActive(true);
            //FindObjectOfType<Lvlcount>().Addtime();

            if (rewardVideo.IsLoaded())
            {
                ad = 5;
                rewardVideo.Show();
                Debug.Log("reward video showing now");
            }
            else if (rewardVideo2.IsLoaded() && !rewardVideo.IsLoaded()) 
            {
                ad = 3;
                rewardVideo2.Show();
                Debug.Log("reward video 2 showing now");
            }
            else
            {
                warn.SetActive(true);
            }
        }
    }


    public void Mapintl()
    {
        if(ad==100)
        ad = 1;
        interstitialView.Show();
        Debug.Log("instead of video, inerstitial is showing now ");
    }

    public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
    }

    public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoFailedToLoad event received with message: " + args.Message);
    }

    public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
    }

    public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
    }

    public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
    {
        this.Requestrewardvideo();
        MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
        
    }

    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        if (ad == 5)
        {
            FindObjectOfType<Lvlcount>().Addtime();
            ad = 0;
        }
        else if (ad == 7)
        {
            FindObjectOfType<Skiplevel>().Skip();
            FindObjectOfType<Skiplevel>().Noskip();
            ad = 0;
        }
    }


    //...................................................REWARD VIDEO AD 2 ............................................//


    public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
    }

    void Requestrewardvideo2()
    {
        string rewardId2 = Rewardvideoagain;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded video ad with the request.
        this.rewardVideo2.LoadAd(request, rewardId2);
    }


    public void HandleRewardBasedVideoLoaded2(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
    }

    public void HandleRewardBasedVideoFailedToLoad2(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoFailedToLoad event received with message: " + args.Message);
    }

    public void HandleRewardBasedVideoOpened2(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
    }

    public void HandleRewardBasedVideoStarted2(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
    }

    public void HandleRewardBasedVideoClosed2(object sender, EventArgs args)
    {
        this.Requestrewardvideo2();
        MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
    }

    public void HandleRewardBasedVideoRewarded2(object sender, Reward args)
    {
        if (ad == 3)
        {
            FindObjectOfType<Lvlcount>().Addtime();
            ad = 0;
        }
        else if (ad == 9)
        {
            FindObjectOfType<Skiplevel>().Skip();
            FindObjectOfType<Skiplevel>().Noskip();
            ad = 0;
        }
    }

    public void HandleRewardBasedVideoLeftApplication2(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
    }
    
}
