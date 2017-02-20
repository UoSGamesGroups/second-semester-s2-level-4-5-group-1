using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addRecoil : MonoBehaviour {

public float recoilForce;				// Thrust applied to projectile
public Rigidbody2D PCrb;				// Projectile's rigidBody
public GameObject PC;

	void OnButtonDown()
		{
			PCrb = GetComponent<Rigidbody2D> ();
			PCrb.AddForce (transform.up * recoilForce);       // Adds a single blast of force to the projectile
		}
	}