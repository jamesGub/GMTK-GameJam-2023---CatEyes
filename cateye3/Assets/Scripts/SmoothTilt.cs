using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothTilt : MonoBehaviour
{
    public float tiltAmount = 10f; // Amount of tilt in degrees
    public float tiltSpeed = 1f; // Speed of the tilt
    public float moveDistance = 15f; // Maximum distance the object can move
    public float moveSpeed = 5f; // Speed of the object's movement

    private Quaternion initialRotation; // Initial rotation of the object
    private float initialYPosition; // Initial Y position of the object
    private float targetYPosition; // Target Y position for smooth movement
    private Rigidbody rb; // Rigidbody component for physics-based movement

    private void Start()
    {
        initialRotation = transform.rotation; // Store the initial rotation
        initialYPosition = transform.position.y; // Store the initial Y position
        targetYPosition = initialYPosition; // Set initial target position to current Y position
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
    }

    private void FixedUpdate()
    {
        float tiltInput = Input.GetAxis("Horizontal"); // Tilt input value

        // Calculate the target rotation based on input and tilt amount
        Quaternion targetRotation = Quaternion.Euler(
            initialRotation.eulerAngles.x,
            initialRotation.eulerAngles.y,
            tiltInput * tiltAmount
        );

        // Smoothly interpolate towards the target rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, tiltSpeed * Time.fixedDeltaTime);

        // Move the object up with "W" key
        if (Input.GetKeyDown(KeyCode.W))
        {
            targetYPosition = Mathf.Clamp(transform.position.y + moveDistance, initialYPosition, initialYPosition + moveDistance);
        }

        // Move the object down with "S" key
        if (Input.GetKeyDown(KeyCode.S))
        {
            targetYPosition = Mathf.Clamp(transform.position.y - moveDistance, initialYPosition - moveDistance, initialYPosition);
        }

        // Update the object's position based on movement input with interpolation
        Vector3 newPosition = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, targetYPosition, transform.position.z), moveSpeed * Time.fixedDeltaTime);
        if (rb != null)
        {
            rb.MovePosition(newPosition); // Apply physics-based movement
        }
        else
        {
            transform.position = newPosition; // Apply transform-based movement
        }
    }
}