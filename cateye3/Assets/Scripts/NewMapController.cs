using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMapController : MonoBehaviour
{

     public GameObject ball;                // Reference to the ball character
     public float tiltSpeed = 5f;   

     private Vector3 initialRotation;
    // Start is called before the first frame update
    void Start()
    {
        initialRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = ball.transform.position - transform.position;
        float tiltAngle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        // Apply the tilt rotation to the map
        Quaternion targetRotation = Quaternion.Euler(initialRotation.x, initialRotation.y, tiltAngle);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, tiltSpeed * Time.deltaTime);
    }
}
