using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;




// 加：Note on MonoBehaviour Class:
// deriving our class from MonoBehaviour which essentially turns our class 
// into an Unity Component that we can then drop onto a GameObject or Prefab.
// It then has access to important methods and properties such as Awake() and Start().
public class Launcher : MonoBehaviourPunCallbacks
{




    // MonoBehaviour method called on GameObject by Unity during initialization phase
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("=====Start() Launcher=====");
        //Debug.Log("Connecting to MMO Expo ...");
        PhotonNetwork.ConnectUsingSettings();   // 加： connect to Photon Online Server using ID
        


    }



    // a callback called by Photon when we successfully connect to the master server
    // joins lobby after connected to master
    public override void OnConnectedToMaster()
    {
        //Debug.Log("Connected to " + PhotonNetwork.CloudRegion);
        //Debug.Log("Connected to MMO Expo");
        PhotonNetwork.JoinLobby();
    }



    public override void OnJoinedLobby()
    {
        //Debug.Log("Joined Lobby");
        SceneManager.LoadScene("LauncherScene", LoadSceneMode.Single);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
