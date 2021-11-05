using Firebase;
using Firebase.Extensions;
using Firebase.Messaging;
using GoogleMobileAds.Api;
using UnityEngine;

public class ReproductionTest : MonoBehaviour
{
    private void Start()
    {
        MessageReceivedEventArgs foo;
        MobileAds.Initialize(_ => Debug.Log("Admob init"));
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(_ => Debug.Log("firebase init"));
    }
}
