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
        //                      LEFT
        //|----------------------------------------------------|
        if(Input.GetKey(left))
        {
            if (Input.GetKey(left) && Input.GetKey(up))
            {
                velocity.x = -moveSpeed;
                velocity.y = moveSpeed;
            }
            if (Input.GetKey(left) && Input.GetKey(down))
            {
                velocity.x = -moveSpeed;
                velocity.y = -moveSpeed;

            }
            velocity.x = -moveSpeed;
            GetComponent<SpriteRenderer>().flipX = true;
        }

        //|----------------------------------------------------|

        //                      RIGHT
        //|----------------------------------------------------|
        else if(Input.GetKey(right))
        {
            if (Input.GetKey(right) && Input.GetKey(up))
            {
                velocity.x = moveSpeed;
                velocity.y = moveSpeed;
            }
            if (Input.GetKey(right) && Input.GetKey(down))
            {
                velocity.x = moveSpeed;
                velocity.y = -moveSpeed;
            }
            velocity.x = moveSpeed;
            GetComponent<SpriteRenderer>().flipX = false;
        }

        //|----------------------------------------------------|

        //                      UP
        //|----------------------------------------------------|
        else if(Input.GetKey(up))
        {
            velocity.y = moveSpeed;
        }
        //|----------------------------------------------------|


        //                      Down
        //|----------------------------------------------------|
        else if(Input.GetKey(down))
        {
            velocity.y = -moveSpeed;
        }
        //|----------------------------------------------------|


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
