using GoogleMobileAds.Api;
using UnityEngine;

public class AdManager : MonoBehaviour
{
    private RewardedAd rewardedAd;

    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.rewardedAd = new RewardedAd("your_ad_unit_id_here");

        this.rewardedAd.OnUserEarnedReward += (sender, args) =>
        {
            Debug.Log("Reward Earned!");
        };

        this.rewardedAd.LoadAd(new AdRequest.Builder().Build());
    }

    public void ShowRewardedAd()
    {
        if (this.rewardedAd.IsLoaded())
            this.rewardedAd.Show();
    }
}
