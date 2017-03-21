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

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        if(GetComponent<Rigidbody2D>() != null)
        {
            rigidbody_ = GetComponent<Rigidbody2D>();
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = sprite1;
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
            switch (bounces_)
            {
                case 0:
                    spriteRenderer.sprite = sprite1;
                    break;
                case 1:
                    spriteRenderer.sprite = sprite2;
                    break;
                case 2:
                    spriteRenderer.sprite = sprite3;
                    break;
                case 3:
                    spriteRenderer.sprite = sprite4;
                    break;
                case 4:
                    spriteRenderer.sprite = sprite5;
                    break;
                default:
                    spriteRenderer.sprite = sprite1;
                    break;
            }
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
