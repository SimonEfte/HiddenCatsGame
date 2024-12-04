using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamInt : MonoBehaviour
{
    private void Start()
    {
        Steamworks.SteamClient.Init(2386330);
        //PrintYourName();
    }

    public void PrintYourName()
    {
        Debug.Log(Steamworks.SteamClient.Name);
    }

    private void Update()
    {
        Steamworks.SteamClient.RunCallbacks();
    }

    private void OnApplicationQuit()
    {
        Steamworks.SteamClient.Shutdown();
    }

}
