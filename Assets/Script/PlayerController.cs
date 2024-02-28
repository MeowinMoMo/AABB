using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpHeight = 2f; // Height of the jump
    public float jumpDuration = 0.5f; // Duration of the jump

    private bool isJumping = false;
    private float jumpStartTime;
    private Vector2 startPos;

    public float terminalVelocity = 10f;

    public bool gravityOn = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            StartJump();
        }

        if (isJumping)
        {
            PerformJump();

        }
        else if (!isJumping && gravityOn)
        {
            // If jump is finished and gravity is enabled, apply gravity
            ApplyGravity();
        }
    }

    void StartJump()
    {
        isJumping = true;
        jumpStartTime = Time.time;
        startPos = transform.position;
    }

    void PerformJump()
    {
        float timeSinceJumpStart = Time.time - jumpStartTime;
        if (timeSinceJumpStart >= jumpDuration)
        {
            // Jump finished
            isJumping = false;
            gravityOn = true; // Enable gravity when jump is finished
            return;
           
        }

        float t = timeSinceJumpStart / jumpDuration;
        float newY = Mathf.Lerp(startPos.y, startPos.y + jumpHeight, t);

        // Update the player's position
        transform.position = new Vector2(transform.position.x, newY);
    }
    void ApplyGravity()
    {
        // Apply gravity to the player
        transform.Translate(Vector2.down * Time.deltaTime * 9.8f); // Adjust gravity strength if needed
    }   




}
