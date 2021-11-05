using Firebase;
using Firebase.Extensions;
using Firebase.Messaging;
using GoogleMobileAds.Api;
using UnityEngine;

public class ReproductionTest : MonoBehaviour
{
    private void Start()
    {
        // Each one of these lines is required for the crash to occur. (The debug statements don't matter of course).
        // You can try removing one and confirming the segfault does not occur.
        MessageReceivedEventArgs foo;
        MobileAds.Initialize(_ => Debug.Log("Admob init"));
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(_ => Debug.Log("firebase init"));
    }
}
