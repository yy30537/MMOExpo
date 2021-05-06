using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.Party;
using PlayFab.ClientModels;

public class HelloParyLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Log into playfab
        var request = new LoginWithCustomIDRequest { CustomId = UnityEngine.Random.value.ToString(), CreateAccount = true };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnLoginSuccess(LoginResult result)
    {
        PlayFabMultiplayerManager.Get().CreateAndJoinNetwork();
        PlayFabMultiplayerManager.Get().OnNetworkJoined += OnNetworkJoined;
    }

    private void OnLoginFailure(PlayFabError error)
    {
    }

    private void OnNetworkJoined(object sender, string networkId)
    {
        // Print the Network ID so you can give it to the other client.
        Debug.Log(networkId);
    }
}
