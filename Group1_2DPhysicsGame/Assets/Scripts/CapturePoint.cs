using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturePoint : MonoBehaviour 
{
	public Material [] material;
	Renderer rend;

	//public GameObject BlueZones;
	//private Score_Display BlueAccess;
	//private int blueInteger;

	// Use this for initialization
	void Start () 
	{
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];

	//	BlueAccess = BlueZones.GetComponent<Score_Display> ();
	//	blueInteger = BlueAccess.blueZoneCounter;

	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Blue_Team") {
			print ("Blue Capture");
			rend.sharedMaterial = material [1];
		//	blueInteger + 1;

		} 

		if (other.tag == "Red_Team") {
			print ("Red Capture");
			rend.sharedMaterial = material [2];

		}

	}
}
