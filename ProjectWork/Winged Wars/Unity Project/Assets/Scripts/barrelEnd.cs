using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelEnd : MonoBehaviour {

	public GameObject projectile;             // Projectile game object being spawn
	public float recoilForce;                 // Amount of recoil
	public Rigidbody2D canonRigidBody;        // RigidBody that force is applied to
    public Transform target;                  //barrelEndRed
    //public Rigidbody2D playerRB;              

    public string fire;
	void start()
    {
        canonRigidBody = GetComponent<Rigidbody2D>();
    }
	// Update is called once per frame
	void Update () 
	{
        {   
            // Rotates object to aim at barrelEndRed
            Vector3 difference = target.position - transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        }

            if (Input.GetButtonDown(fire))
		    {
            Instantiate(projectile, target.position, target.rotation);      // Creates projectiles
            canonRigidBody.AddForce(transform.right * recoilForce);         // Adds recoil/kick-back
		    }
    }
}