using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelRotateScript : MonoBehaviour {

	public int aimSpeed = 5;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	void FixedUpdate()
	{
       // Horozontal movement 
		var move = new Vector3(Input.GetAxis("Vertical"), 0, 0);
		transform.Rotate (Vector3.forward);   
	}
}

