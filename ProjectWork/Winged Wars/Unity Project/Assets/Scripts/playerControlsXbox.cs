using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlsXbox : MonoBehaviour
{
    public string leftJoystickX = "Joystick1LeftVertical";
    public string leftJoystickY = "Joystick1LeftHorizontal";

    public float SPEED;

	// Update is called once per frame
	void Update ()
    {
        float horizontalSpeed = Input.GetAxis(leftJoystickX);
        float verticalSpeed = Input.GetAxis(leftJoystickY);

        //Debug.Log("X: " + horizontalSpeed + ", Y: " + verticalSpeed);
       

        Vector2 velocity = new Vector2(horizontalSpeed * SPEED, verticalSpeed  * SPEED);

        GetComponent<Rigidbody2D>().velocity = velocity;

    }
}
