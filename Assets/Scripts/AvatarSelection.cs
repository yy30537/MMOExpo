using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvatarSelection : MonoBehaviour
{
    public GameObject[] Avatars;
    public int selectedAvatar = 0;

    public GameObject NextBT;
    public GameObject PreviousBT;
    public GameObject ConfirmBT;


    void Start()
    {
        Debug.Log("=====Start() AvatarSelection=====");
        NextBT.SetActive(true);
        PreviousBT.SetActive(true);
        ConfirmBT.SetActive(true);

    }

    public void NextAvatar()
    {
        Debug.Log("NextAvatar");
        Avatars[selectedAvatar].SetActive(false);
        selectedAvatar = (selectedAvatar + 1) % Avatars.Length;
        Avatars[selectedAvatar].SetActive(true);
        //Debug.Log("selectedAvatar" + selectedAvatar);
    }

    public void PreviousAvatar()
    {
        Debug.Log("PreviousAvatar");
        Avatars[selectedAvatar].SetActive(false);
        selectedAvatar--;
        if (selectedAvatar < 0)
        {
            selectedAvatar += Avatars.Length;
        }
        Avatars[selectedAvatar].SetActive(true);
    }

    public void StartGame()
    {
        Debug.Log("StartGame");
        // Stores and accesses player preferences between game sessions
        //PlayerPrefs.SetInt("selectedAvatar", selectedAvatar);
        //SceneManager.LoadScene("ExpoMainScene", LoadSceneMode.Single);
        SceneManager.LoadScene("LauncherScene", LoadSceneMode.Single);
    }
}
