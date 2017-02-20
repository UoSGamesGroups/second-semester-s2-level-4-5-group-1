using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{

    public float thrust;                // Thrust applied to projectile
    public Rigidbody2D rb;              // Projectile's rigidBody
    public GameObject Projectile;

    private int boundsHit = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * thrust);       // Adds a single blast of force to the projectile
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Boundry")
        {
            boundsHit += 1;
            if (boundsHit == 3)
            {
                bulletHit();
            }
        }
    }

    void bulletHit()
    {
        Destroy(this.gameObject);
    }
}

