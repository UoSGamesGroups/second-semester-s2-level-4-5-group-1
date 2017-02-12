using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public Rigidbody2D playerRigidbody;	   // player RigidBody
	public float driveSpeed = 5;           // speed of the player tank
	public float tankDirection;			   // direction the tank is facing (left or right)

	private bool grounded = false;         // is player touching the floor
	public GameObject projectile;
	public GameObject barrelEnd;




	// Update is called once per frame
	void FixedUpdate()
	{
		var move = new Vector3(Input.GetAxis("LeftJoystickHorizontal"), 0, 0);
		transform.position += move * driveSpeed * Time.deltaTime;         // Horozontal movement 

		//PlayerDirection = (Input.GetAxis("Horizontal"));                // for flip sprite if needed
	}


}
