using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelEnd : MonoBehaviour {

	public GameObject projectile;             // Projectile game object being spawn
	public float recoilForce;                 // Amount of recoil
	public Rigidbody2D canonRigidBody;        // RigidBody that force is applied to

    public string Fire1 = "Joystick1ButtonA";

    // Use this for initialization
    void Start () {}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown(Fire1))
		{
			Instantiate(projectile, transform.position, transform.rotation);		// Creates projectiles
		}
    }

/*	void recoil() 

	{
		canonRigidBody = GetComponent<Rigidbody2D> ();
		canonRigidBody.AddForce (transform.right * recoilForce);;
	}

*/	

}
