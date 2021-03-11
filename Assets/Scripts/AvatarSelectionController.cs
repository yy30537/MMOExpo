using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvatarSelectionController : MonoBehaviour
{
    //[SerializeField]

    [SerializeField]
    private GameObject SelectAvatarButton;

    //public GameObject[] avatarPrefabs;
    //public Transform spawnPoint;

    void Start()
    {
        Debug.Log("=====Start() CreateAvatarController=====");
    }

    public void launchAvatarSelectionPage()
    {
        SceneManager.LoadScene("AvatarSelectionScene", LoadSceneMode.Single);
    }


}
