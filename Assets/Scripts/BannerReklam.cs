using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;
public class BannerReklam : MonoBehaviour
{
    private BannerView bannerView;
    
    
    public void Start()
    {
        
            string appId = "ca-app-pub-9132047025891240~7393931171";
        
        
     

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        this.RequestBanner();
    }

    private void RequestBanner()
    {
        
        string adUnitId = "ca-app-pub-9132047025891240/9418648656";
        

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }


}
