using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelEnd : MonoBehaviour {

	public GameObject projectile;             // Projectile game object being spawn
	public Rigidbody2D canonRigidBody;        // RigidBody that force is applied to

    public string fire;
    bool canFire = true;

    public float RateOfFire = 0.2f;

    void Update () 
	{           
	        if (Input.GetAxis(fire) != 0 && canFire == true)
	        {
	            Instantiate(projectile, transform.position, transform.rotation); // Creates projectiles
	            canFire = false;

	            StartCoroutine(FireControl());
	        }
	    

	}

    IEnumerator FireControl()
    {
        yield return new WaitForSeconds(RateOfFire);

        canFire = true;
    }
}
