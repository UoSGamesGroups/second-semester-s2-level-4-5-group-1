using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForceMan : MonoBehaviour {

    public float thrust;                // Thrust applied to projectile
    public Rigidbody2D rb0;              // Projectile's rigidBody
    /*
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    public Rigidbody2D rb3;
    public Rigidbody2D rb4;
    public Rigidbody2D rb5;
    public Rigidbody2D rb6;
    public Rigidbody2D rb7;
    public Rigidbody2D rb8;
    public Rigidbody2D rb9;
    */


    public GameObject man;

    void Start()
    {
        rb0 = GetComponent<Rigidbody2D>();
        /*
        rb1 = GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();
        rb3 = GetComponent<Rigidbody2D>();
        rb4 = GetComponent<Rigidbody2D>();
        rb5 = GetComponent<Rigidbody2D>();
        rb6 = GetComponent<Rigidbody2D>();
        rb7 = GetComponent<Rigidbody2D>();
        rb8 = GetComponent<Rigidbody2D>();
        rb9 = GetComponent<Rigidbody2D>();
        */
        rb0.AddForce(transform.up * thrust);       // Adds a single blast of force to the projectile
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Boundry")
        {
            ManDown();
        }
    }

    void ManDown()
    {
        man.SetActive(false);
    }
}