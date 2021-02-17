using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateAvatarController : MonoBehaviour
{
    //[SerializeField]

    

    //public GameObject[] avatarPrefabs;
    //public Transform spawnPoint;

    void Start()
    {
        Debug.Log("in Start(), CreateAvatarController");
        //int selectedAvatar = PlayerPrefs.GetInt("selectedAvatar");
        //GameObject prefab = avatarPrefabs[selectedAvatar];
        //GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);


    }

    public void launchAvatarSelectionPage()
    {
        SceneManager.LoadScene("AvatarSelectionScene", LoadSceneMode.Single);
    }


}
