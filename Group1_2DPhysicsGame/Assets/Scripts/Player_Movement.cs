using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float moveSpeed;
    public KeyCode left, right, up, down;

    private Vector3 defaultScale;
    private Vector2 velocity;
 

    private void Start()
    {
        defaultScale = GetComponent<Transform>().localScale;
    }

    private void UserInput()
    {
        if (Input.GetKey(left))
        {
            velocity.x = -moveSpeed;
            GetComponent<Transform>().localScale = new Vector3(-defaultScale.x, defaultScale.y, defaultScale.z);
        }
        else if (Input.GetKey(right))
        {
            velocity.x = moveSpeed;
            GetComponent<Transform>().localScale = new Vector3(defaultScale.x, defaultScale.y, defaultScale.z);

        }
        else if (Input.GetKey(up))
        {
            velocity.y = moveSpeed;
            GetComponent<Transform>().localScale = new Vector3(defaultScale.x, defaultScale.y, defaultScale.z);

        }
        else if (Input.GetKey(down))
        {
            velocity.y = -moveSpeed;
            GetComponent<Transform>().localScale = new Vector3(defaultScale.x, defaultScale.y, defaultScale.z);

        }
        else
        {
            velocity.x = 0;
            velocity.y = 0;
        }
    }


        void Update()
        {
        UserInput();
        //velocity *= Time.deltaTime;

        GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x,  velocity.y);

        velocity = Vector2.zero;

    }


}
