using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelEnd : MonoBehaviour {

	public GameObject projectile;             // Projectile game object being spawn

    public string fire;
    bool canFire = true;

    public float RateOfFire = 0.2f;

    public float RecoilAmount;
    public Transform PlayerTransform;

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
