using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
     public float boostForce = 1f; // The force to apply to the ball for the speed boost

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CatBall"))
        {
            Rigidbody2D ballRigidbody = other.GetComponent<Rigidbody2D>();
            Vector2 currentVelocity = ballRigidbody.velocity;
            Vector2 boostVelocity = currentVelocity.normalized * boostForce;
            ballRigidbody.velocity = boostVelocity;
        }
    }
}
