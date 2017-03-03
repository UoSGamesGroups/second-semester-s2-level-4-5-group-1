using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{

    public GameObject explosionObj;
    public GameObject projectileObj;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Environ")
        {
            explosionObj.SetActive(true);
            explosionObj.transform.parent = null;
            Debug.Log("Kapow!");

            projectileObj.SetActive(false);
        }
    }
}
