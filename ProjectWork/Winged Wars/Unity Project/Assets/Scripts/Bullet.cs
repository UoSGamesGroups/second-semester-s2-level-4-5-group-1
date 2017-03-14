using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private LayerMask wall_layer_;
    [SerializeField]
    private int speed_;
    [SerializeField]
    private int bounces_;

    private Rigidbody2D rigidbody_;
    private int times_bounced_;

    private void Start()
    {
        if(GetComponent<Rigidbody2D>() != null)
        {
            rigidbody_ = GetComponent<Rigidbody2D>();
        }
    }

    private void rotate_to(Vector2 direction)
    {
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void Update()
    {
        if(rigidbody_ == null)
        {
            return;
        }

        rigidbody_.AddForce(transform.up * speed_ * Time.deltaTime, ForceMode2D.Impulse);
        rigidbody_.velocity = Vector2.ClampMagnitude(rigidbody_.velocity, speed_);

        rotate_to(rigidbody_.velocity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (wall_layer_ == (wall_layer_ | (1 << collision.gameObject.layer)))
        {
            if(++times_bounced_ == bounces_)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Red_Team") || collision.gameObject.CompareTag("Blue_Team"))
        {
            Destroy(gameObject);
        }
    }   

}
