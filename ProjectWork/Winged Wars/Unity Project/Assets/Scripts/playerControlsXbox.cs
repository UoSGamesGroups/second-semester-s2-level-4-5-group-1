using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlsXbox : MonoBehaviour
{
    public string leftJoystickX = "Joystick1LeftVertical";
    public string leftJoystickY = "Joystick1LeftHorizontal";

    public float SPEED;
    public float pushTime;

    public GameObject projectile;             // Projectile game object being spawn

    public string fire;
    bool canFire = true;

    public float RateOfFire = 0.2f;

    public float RecoilAmount;
    public Transform ShotPosition;

    // Update is called once per frame
    void Update ()
    {
        float horizontalSpeed = Input.GetAxis(leftJoystickX);
        float verticalSpeed = Input.GetAxis(leftJoystickY);

        //Debug.Log("X: " + horizontalSpeed + ", Y: " + verticalSpeed);
       

        Vector2 velocity = new Vector2(horizontalSpeed * SPEED, verticalSpeed  * SPEED);

        GetComponent<Rigidbody2D>().velocity = velocity;

        if(Input.GetAxis(fire) != 0 && canFire == true)
        {
            Instantiate(projectile, ShotPosition.position, transform.rotation); // Creates projectiles
            canFire = false;

            Vector2 PushBack = -transform.forward * RecoilAmount;

            GetComponent<Rigidbody2D>().velocity = PushBack;

            StartCoroutine(FireControl());
        }
    }

    IEnumerator FireControl()
    {
        yield return new WaitForSeconds(RateOfFire);

        canFire = true;
    }

    IEnumerator canPush()
    {
        yield return new WaitForSeconds(pushTime);

    }
}
