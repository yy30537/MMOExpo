using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting to MMO Expo ...");
        PhotonNetwork.ConnectUsingSettings();
    }

    // a callback called by Photon when we successfully connect to the master server
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to MMO Expo");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        MenuManager.instance.OpenMenu("title");
        Debug.Log("Joined Lobby");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
