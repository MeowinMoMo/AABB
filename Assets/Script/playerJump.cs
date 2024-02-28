using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{
    public float jumpForce = 500f;
    public float gravity = 20f;
    private Vector2 playerVelocity;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerVelocity.y = jumpForce;
        }

        playerVelocity.y -= gravity * Time.deltaTime;
/*        transform.position += playerVelocity * Time.deltaTime;*/
    }
}
