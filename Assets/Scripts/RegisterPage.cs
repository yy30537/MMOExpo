using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegisterPage : MonoBehaviour
{
    public GameObject[] Avatars;
    public int selectedAvatar = 0;
    public Button QuitButton;


    // Start is called before the first frame update
    void Start()
    {
        Button Quitbtn = QuitButton.GetComponent<Button>();
        Quitbtn.onClick.AddListener(QuitGame);
    }


    public void GoToMainScene()
    {
        
        SceneManager.LoadScene("LauncherScene", LoadSceneMode.Single);
        
    }

    private void QuitGame()
    {
        Application.Quit();
    }

}
