using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw ("Horizontal") > 0) 
		{
			transform.Translate (Vector2.right * Time.deltaTime * moveSpeed);	
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) 
		{
			transform.Translate (Vector2.left * Time.deltaTime * moveSpeed);	
		}
	}
}
