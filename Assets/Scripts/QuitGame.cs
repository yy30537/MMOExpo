using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button Quitbtn = QuitButton.GetComponent<Button>();
        Quitbtn.onClick.AddListener(QuitGameFunc);
    }

    private void QuitGameFunc()
    {
        Application.Quit();
    }
}
