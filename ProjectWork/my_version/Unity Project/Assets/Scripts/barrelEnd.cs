using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelEnd : MonoBehaviour 

{

	public GameObject projectile;             // Projectile game object being spawn
	//public float recoilForce;                 // Amount of recoil
	//public Rigidbody2D canonRigidBody;        // RigidBody that force is applied to

	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			Instantiate (projectile, transform.position, transform.rotation);		// Creates projectiles
//			canonRigidBody = GetComponent<Rigidbody2D> ();
//			canonRigidBody.AddForce (transform.up * recoilForce);
		}
	}

}
