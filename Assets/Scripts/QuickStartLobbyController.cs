using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
//using System;
using UnityEngine;


public class QuickStartLobbyController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject quickStartButton;

    [SerializeField]
    private GameObject quickCancelButton;

    [SerializeField]
    private int RoomSize;

    public override void OnConnectedToMaster()
    {

        // this makes sure we can use PhotonNetwork.LoadLevel() on the master 
        // client and all clients in the same room sync their level automatically
        PhotonNetwork.AutomaticallySyncScene = true;

        // enable the quick start button after connected
        quickStartButton.SetActive(true);
    }

    public void QuickStart()
    {
        quickStartButton.SetActive(false);
        quickCancelButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();     // after connected, attempt joining a Random Room. 
                                            
        Debug.Log("Quick start");
    }


    // ¼Ó£º If joining a Random Room fails, we'll get notified in OnJoinRandomFailed() and we'll create one.
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to join a room");
        CreateRoom();
    }

    void CreateRoom()
    {
        Debug.Log("Creating room now");
        int randomRoomNumber = Random.Range(0, 100);
        RoomOptions roomOps = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)RoomSize };
        PhotonNetwork.CreateRoom("Room" + randomRoomNumber, roomOps);
        Debug.Log(randomRoomNumber);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to create room... Trying again");
        CreateRoom();
    }

    public void QuickCancel()
    {
        quickCancelButton.SetActive(false);
        quickStartButton.SetActive(true);
        PhotonNetwork.LeaveRoom();
    }

    // to be implemented: public override void OnDisconnected


}