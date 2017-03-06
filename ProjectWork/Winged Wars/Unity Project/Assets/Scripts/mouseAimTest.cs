using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseAimTest : MonoBehaviour
{
    public static float speed = 5f;
    public float aimAngle = 45f;
    public string rightJoystickX = "rightJoystickHorizontal";
    public string rightJoystickY = "rightJoystickVertical";

    void start()
    { 

    }

    void Update()
	{
        float horizontal = Input.GetAxis(rightJoystickX) * Time.deltaTime;// * speed;
        float vertical = Input.GetAxis(rightJoystickY) * Time.deltaTime;// * speed;
        //Vector2 direction = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2 (horizontal, vertical ) * Mathf.Rad2Deg + aimAngle;
		Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, speed * Time.deltaTime);
	}
}
