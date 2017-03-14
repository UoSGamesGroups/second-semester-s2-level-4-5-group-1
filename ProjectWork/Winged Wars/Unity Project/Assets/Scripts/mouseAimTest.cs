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

    private Vector3 currentAimPosition;
    private Vector3 lastRememberedPosition;
    private Vector3 defaultPos = new Vector3(0, 0, 0);

    void Start()
    {

    }

    void Update()
    {
        float horizontal = Input.GetAxis(rightJoystickX);// * Time.deltaTime;// * speed;
        float vertical = Input.GetAxis(rightJoystickY); // * Time.deltaTime;// * speed;

        //Debug.Log(Mathf.Atan2(vertical, horizontal) * 180 / Mathf.PI);

        //Remember where we were looking last frame
        lastRememberedPosition = currentAimPosition;
        //Update our current position using input from the controller
        currentAimPosition = new Vector3(0, 0, Mathf.Atan2(vertical, horizontal) * 180 / Mathf.PI);

        //If our stick is up
        if(currentAimPosition.z == 0)
        {
            //Look at our last position
            Debug.Log("Aim == 0");
            transform.eulerAngles = lastRememberedPosition;
        }
        //Otherwise
        else if (currentAimPosition.z != 0)
        {
            //Update our position from input
            Debug.Log("Taking aim from con");
            transform.eulerAngles = currentAimPosition;
        }



        /*horizontalAim += horizontal;
        verticalAim += vertical;
        //Vector2 direction = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2 (horizontalAim, verticalAim) * Mathf.Rad2Deg + 45;
		Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, speed * Time.deltaTime);*/
    }
}
