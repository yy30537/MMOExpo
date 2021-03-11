using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_avatarController : MonoBehaviour
{
    public GameObject[] Avatars;
    public int selectedAvatar = 0;

    // Start is called before the first frame update
    void Start()
    {
        Avatars[0].SetActive(false);
        selectedAvatar = PlayerPrefs.GetInt("selectedAvatar");
        Avatars[selectedAvatar].SetActive(true);
    }

}
