using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterPage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ConfirmRegister()
    {
        SceneManager.LoadScene("LauncherScene", LoadSceneMode.Single);
    }
}
