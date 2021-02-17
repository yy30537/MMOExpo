using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterPageController : MonoBehaviour
{
    //[SerializeField]

    [SerializeField]
    private GameObject SelectAvatarButton;

    //public GameObject[] avatarPrefabs;
    //public Transform spawnPoint;

    void Start()
    {
        Debug.Log("=====Start() RegisterPageController=====");
        //int selectedAvatar = PlayerPrefs.GetInt("selectedAvatar");
        //GameObject prefab = avatarPrefabs[selectedAvatar];
        //GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);


    }

    public void launchRegisterPage()
    {
        SceneManager.LoadScene("RegisterScene", LoadSceneMode.Single);
    }


}
