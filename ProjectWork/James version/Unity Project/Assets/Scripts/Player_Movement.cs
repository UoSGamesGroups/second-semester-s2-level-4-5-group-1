using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float moveSpeed;
    public KeyCode left, right, up, down;

    private Vector2 velocity;

    private void UserInput()
    {
        if (Input.GetKey(left))
        {
            velocity.x = -moveSpeed;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetKey(right))
        {
            velocity.x = moveSpeed;
            GetComponent<SpriteRenderer>().flipX = false;

        }
        else if (Input.GetKey(up))
        {
            velocity.y = moveSpeed;
        }
        else if (Input.GetKey(down))
        {
            velocity.y = -moveSpeed;
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
