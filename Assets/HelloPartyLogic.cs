using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.Party;
using PlayFab.ClientModels;
using System.Text;

public class HelloPartyLogic : MonoBehaviour
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
        if (Input.GetButtonDown("Fire1"))
        {
            byte[] requestAsBytes = Encoding.UTF8.GetBytes("Hello (data message)");
            PlayFabMultiplayerManager.Get().SendDataMessageToAllPlayers(requestAsBytes);
        }

    }

    private void OnLoginSuccess(LoginResult result)
    {
        //var localPlayer = PlayFabMultiplayerManager.Get().LocalPlayer;

        PlayFabMultiplayerManager.Get().CreateAndJoinNetwork();
        PlayFabMultiplayerManager.Get().OnNetworkJoined += OnNetworkJoined;

        PlayFabMultiplayerManager.Get().OnRemotePlayerJoined += OnRemotePlayerJoined;
        PlayFabMultiplayerManager.Get().OnRemotePlayerLeft += OnRemotePlayerLeft;

        PlayFabMultiplayerManager.Get().OnDataMessageReceived += OnDataMessageReceived;

        PlayFabMultiplayerManager.Get().OnChatMessageReceived += OnChatMessageReceived;

    }

    private void OnLoginFailure(PlayFabError error)
    {
    }

    private void OnNetworkJoined(object sender, string networkId)
    {
        // Print the Network ID so you can give it to the other client.
        Debug.Log(networkId);
    }

    private void OnRemotePlayerLeft(object sender, PlayFabPlayer player)
    {
    }

    private void OnRemotePlayerJoined(object sender, PlayFabPlayer player)
    {
        var localPlayer = PlayFabMultiplayerManager.Get().LocalPlayer;
    }

    private void OnDataMessageReceived(object sender, PlayFabPlayer from, byte[] buffer)
    {
        Debug.Log(Encoding.Default.GetString(buffer));
    }

    private void OnChatMessageReceived(object sender, PlayFabPlayer from, string message, ChatMessageType type)
    {
        Debug.Log(message);
    }

}
