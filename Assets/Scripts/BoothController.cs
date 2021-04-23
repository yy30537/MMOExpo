using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoothController : MonoBehaviour
{
    public GameObject panel;
    public bool isOpen;

    private void Start()
    {
        panel.SetActive(false);
        isOpen = false;
    }


    private void OnMouseDown()
    {
        if (isOpen == false)
        {
            panel.SetActive(true);
            isOpen = true;
        } else
        {
            panel.SetActive(false);
            isOpen = false;
        }
        
    }
}
