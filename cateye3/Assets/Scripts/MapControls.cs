using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
**IF YOU WANT TO EDIT FEEL FREE @Shy

Testing this for map controls, comments explain more.
*/

//Default class. 

public class MapControls : MonoBehaviour
{

    // Since we wanted tilt and movement we can determine 2 separate variables.
    public float tiltSpeed = 100f;
    public float moveSpeed = 100f;
    // Horizontal tilt and vertical movement
    private void Update()
    {
        float tiltInput = Input.GetAxis("Horizontal");
        float moveInput = Input.GetAxis("Vertical");

        // Determining input for the tilt and subsequently the movement
        TiltMap(tiltInput);

        MoveMap(moveInput);
    }

        // Next two functions are for WASD input (did not want to use input manager)
       private float GetTiltInput()
    {
        float tiltInput = 0f;

        if (Input.GetKey(KeyCode.A))
            tiltInput += 3f;
        
        if (Input.GetKey(KeyCode.D))
            tiltInput -= 3f;

        return tiltInput;
    }

    // Same thing but for Y axis movement.
    private float GetMoveInput()
    {
        float moveInput = 0f;

        
        if (Input.GetKey(KeyCode.W))
            moveInput += 1f;
        if (Input.GetKey(KeyCode.S))
            moveInput -= 1f;

        return moveInput;
    }

    // Tilt function, literally just calculating the tilt angle. Once we have it, then the map reflects that.
    private void TiltMap(float tiltInput) {
        
        
        float targetAngle = tiltInput * tiltSpeed * 2;
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, targetAngle);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

    }

    // Calculate a vector for the input in the Y for Up/Down.
    private void MoveMap(float moveInput)
    {
       
        Vector3 movement = new Vector3(0f, moveInput, 0f) * moveSpeed * Time.deltaTime;

        // Applied
        transform.Translate(movement);
    }
}
