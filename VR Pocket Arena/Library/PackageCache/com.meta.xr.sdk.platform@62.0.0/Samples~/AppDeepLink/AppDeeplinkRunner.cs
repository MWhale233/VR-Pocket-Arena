using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppDeeplinkRunner : MonoBehaviour
{
    // YOUR APP IDS
    const ulong UNITY_COMPANION_APP_ID = 3535750239844224;
    const ulong UNREAL_COMPANION_APP_ID = 4055411724486843;

    public Text UILaunchType;
    public Text UILaunchSource;
    public Text UIDeeplinkMessage;
    public Text UIMessageToSend;

    // this is the message that will be sent to
    // the launched apps as a DeeplinkMessage
    const string MESSAGE = "MSG_UNITY_SAMPLE";

    Oculus.Platform.Models.LaunchDetails _details;

    void Start()
    {
        // init ovr platform
        if (UnityEngine.Application.platform == RuntimePlatform.Android)
            if (!Oculus.Platform.Core.IsInitialized())
                Oculus.Platform.Core.Initialize();

        UIMessageToSend.text += $" {MESSAGE}";
    }

    void Update()
    {
        if (Application.platform != RuntimePlatform.Android)
            return;

        var launchDetails = Oculus.Platform.ApplicationLifecycle.GetLaunchDetails();
        if (launchDetails == _details)
            return;

        UILaunchType.text = $"Launch Type: {launchDetails.LaunchType}";
        UILaunchSource.text = $"Launch Source: {launchDetails.LaunchSource}";
        UIDeeplinkMessage.text = $"Deeplink Message: {launchDetails.DeeplinkMessage}";

        _details = launchDetails;
    }

    public void LaunchUnrealDeeplinkSample()
    {
        Debug.Log($"LaunchUnrealApp({UNREAL_COMPANION_APP_ID})");
        Launch(UNREAL_COMPANION_APP_ID);
    }

    public void LaunchSelf()
    {
        if (ulong.TryParse(Oculus.Platform.PlatformSettings.MobileAppID, out ulong appId))
        {
            Debug.Log($"LaunchSelf({appId})");
            Launch(appId);
        }
    }

    public void LaunchUnityDeeplinkSample()
    {
        Debug.Log($"LaunchUnityApp({UNITY_COMPANION_APP_ID})");
        Launch(UNITY_COMPANION_APP_ID);
    }

    void Launch(ulong id)
    {
        var options = new Oculus.Platform.ApplicationOptions();
        options.SetDeeplinkMessage(MESSAGE);
        Oculus.Platform.Application.LaunchOtherApp(id, options);
    }
}
