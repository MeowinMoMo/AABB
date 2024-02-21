using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*   public float jumpHeight = 5f;
       public float jumpDuration = 0.5f;
       public float Gravy;
       private float jumpStartTime;
       private bool isJumping;

       void Update()
       {
           // Check for jump input
           if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
           {
               StartJump();
           }

           // Handle jump
           if (isJumping)
           {
               float timeSinceJumpStart = Time.time - jumpStartTime;
               if (timeSinceJumpStart < jumpDuration)
               {
                   // Calculate jump height using a simple upward motion equation
                   float jumpProgress = timeSinceJumpStart / jumpDuration;
                   float jumpHeightThisFrame = Mathf.Lerp(jumpHeight, 0f, jumpProgress * jumpProgress);
                   transform.Translate(Vector3.up * jumpHeightThisFrame * Time.deltaTime);
               }
               else
               {
                   isJumping = false;
               }
           }
       }

       void StartJump()
       {
           isJumping = true;
           jumpStartTime = Time.time;
       }*/

    public float jumpHeight = 5f;
    public float jumpDuration = 0.5f;
    public float gravity = -9.81f;

    private float jumpStartTime;
    private bool isJumping;

    void Update()
    {
        // Check for jump input
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            StartJump();
        }

        // Handle jump
        if (isJumping)
        {
            float timeSinceJumpStart = Time.time - jumpStartTime;

            if (timeSinceJumpStart < jumpDuration)
            {
                // Calculate jump height using a quadratic motion equation
                float jumpProgress = timeSinceJumpStart / jumpDuration;
                float jumpHeightThisFrame = Mathf.Lerp(jumpHeight, 0f, jumpProgress * jumpProgress);

                // Apply gravity
                float gravityThisFrame = gravity * timeSinceJumpStart;
                float verticalMovement = jumpHeightThisFrame + gravityThisFrame;

                transform.Translate(Vector3.up * verticalMovement * Time.deltaTime);
            }
            else
            {
                isJumping = false;
            }
        }
    }

    void StartJump()
    {
        isJumping = true;
        jumpStartTime = Time.time;
    }
}
