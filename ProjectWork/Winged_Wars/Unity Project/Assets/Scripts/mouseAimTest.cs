using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class mouseAimTest : MonoBehaviour
{
    public static float speed = 10f;
    public string rightJoystickX = "rightJoystickHorizontal";
    public string rightJoystickY = "rightJoystickVertical";

    private float verticalAim = 0.0f;
    private float horizontalAim = 0.0f;

    public Vector3 currentAimPosition;
    public Vector3 lastRememberedPosition;
    private Vector3 defaultPos = new Vector3(0, 0, 0);

    public float horizontal;
    public float vertical;

    void Start()
    {

    }

    void Update()
    {
        horizontal = Input.GetAxis(rightJoystickX) * Time.deltaTime;// * speed;
        vertical = Input.GetAxis(rightJoystickY) * Time.deltaTime;// * speed;

        //Debug.Log(Mathf.Atan2(vertical, horizontal) * 180 / Mathf.PI);

        Debug.Log(currentAimPosition);

        //Remember where we were looking last frame
        lastRememberedPosition.z = currentAimPosition.z;

        if (vertical != 0.0f && horizontal != 0.0f)
        {
            //Update our current position using input from the controller
            currentAimPosition = new Vector3(0, 0, Mathf.Atan2(vertical, horizontal)  * 180 / Mathf.PI - 90);
        }

        //If our stick is up
        if(currentAimPosition.z == 0)
        {
            //Look at our last position
            //Debug.Log("Aim == 0");
            transform.eulerAngles = lastRememberedPosition;
        }
        //Otherwise
        else if (currentAimPosition.z != 0)
        {
            //Update our position from input
            //Debug.Log("Taking aim from con");
            transform.eulerAngles = currentAimPosition;
        }
    }
}
