using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlsXbox : MonoBehaviour
{

    string a = "Joystick1ButtonA";
    string b = "Joystick1ButtonB";
    string x = "Joystick1ButtonX";
    string y = "Joystick1ButtonY";

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
