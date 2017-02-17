using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerContorlsXbox : MonoBehaviour
{

    string a = "Joystick1ButtonA";
    string b = "Joystick1ButtonB";
    string x = "Joystick1ButtonX";
    string y = "Joystick1ButtonY";

    string leftJoystickX = "Joystick1LeftVertical";
    string leftJoystickY = "Joystick1LeftHorizontal";

    const float SPEED = 10.0f;

	// Update is called once per frame
	void Update ()
    {
        float horizontalSpeed = Input.GetAxis("Joystick1LeftHorizontal");
        float verticalSpeed = Input.GetAxis("Joystick1LeftVertical");

        Debug.Log("X: " + horizontalSpeed + ", Y: " + verticalSpeed);
       

        Vector2 velocity = new Vector2(horizontalSpeed, verticalSpeed);

        GetComponent<Rigidbody2D>().velocity = velocity;

    }
}
