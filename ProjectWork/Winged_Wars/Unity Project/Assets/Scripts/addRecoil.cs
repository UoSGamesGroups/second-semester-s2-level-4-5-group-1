﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addRecoil : MonoBehaviour {

public float recoilForce;				// Thrust applied to projectile
public Rigidbody2D rb;				// Projectile's rigidBody
public GameObject PC;
public string fire; 


	void Update() { 
        if (Input.GetButtonDown(fire))
		{
            rb = GetComponent<Rigidbody2D>();
			rb.AddForce (transform.up * recoilForce);       // Adds a single blast of force to the projectile
		}
	}
}