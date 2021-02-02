using Photon.Pun;
using System.IO;
using UnityEngine;

public class GameSetupController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        Debug.Log("Creating Player");
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer"), Vector3.zero, Quaternion.identity);
        Debug.Log("Player Created");
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "AvaTest"), Vector3.zero, Quaternion.identity);
        Debug.Log("Avatar created (capsule)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
