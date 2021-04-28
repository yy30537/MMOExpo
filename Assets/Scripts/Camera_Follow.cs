using UnityEngine;
using System.Collections;

public class Camera_Follow : MonoBehaviour
{
    private Vector3 offset;
    private GameObject player;

    void Start()
    {
        offset = transform.position;
    }

    void LateUpdate()
    {
        Debug.Log("Calling follow");
        if (player == null)
        {
            player = GameObject.Find("myPlayer(Clone)");
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}