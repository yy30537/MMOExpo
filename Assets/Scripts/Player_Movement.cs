using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float move_speed;
    private Animator anim;
    private bool is_moving;
    private Vector2 lastmove;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("in Start(), Player_Movement");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        is_moving = false;
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * move_speed * Time.deltaTime, 0f, 0f));
            is_moving = true;
            lastmove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * move_speed * Time.deltaTime, 0f));
            is_moving = true;
            lastmove = new Vector2(0f,Input.GetAxisRaw("Vertical"));
        }



        anim.SetFloat("move_x", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("move_y", Input.GetAxisRaw("Vertical"));
        anim.SetBool("is_moving", is_moving);
        anim.SetFloat("lastmove_x", lastmove.x);
        anim.SetFloat("lastmove_y", lastmove.y);
    }
}
