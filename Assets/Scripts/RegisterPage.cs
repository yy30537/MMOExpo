using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterPage : MonoBehaviour
{
    public GameObject[] Avatars;
    public int selectedAvatar = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void GoBackToLauncherScene()
    {
        SceneManager.LoadScene("LauncherScene", LoadSceneMode.Single);
    }

    public void GoToMainScene()
    {
        
        SceneManager.LoadScene("ExpoMainScene", LoadSceneMode.Single);
        
    }

}
