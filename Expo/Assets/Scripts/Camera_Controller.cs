using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{

    public GameObject target_followed;
    private Vector3 target_position;
    public float move_speed;

    void Start()
    {
        
    }


    void Update()
    {
        target_position = new Vector3(target_followed.transform.position.x, target_followed.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, target_position, move_speed * Time.deltaTime);
    }
}
