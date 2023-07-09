using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float bounceForceMultiplier = 10f;
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CatBall")) { 

            Rigidbody2D ballRigidbody = other.GetComponent<Rigidbody2D>();
            float ballMass = ballRigidbody.mass;
            float bounceForce = ballMass * bounceForceMultiplier;
            Vector2 bounceDirection = (other.transform.position - transform.position).normalized;
            ballRigidbody.AddForce(bounceDirection * bounceForce, ForceMode2D.Impulse);

            
        }
    }
}
