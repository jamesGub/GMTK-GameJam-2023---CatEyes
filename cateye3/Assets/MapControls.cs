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
    public float tiltSpeed = 1f;
    public float moveSpeed = 1f;

    // Horizontal tilt and vertical movement
    private void Update()
    {
        float tiltInput = Input.GetAxis("Horizontal");
        float tiltInput = Input.GetAxis("Vertical");

        // Determining input for the tilt and subsequently the movement
        TiltMap(tiltInput);

        MoveMap(MoveInput);
    }

        // Next two functions are for WASD input (did not want to use input manager)
       private float GetTiltInput()
    {
        float tiltInput = 0f;

        if (Input.GetKey(KeyCode.A))
            tiltInput += 1f;
        
        if (Input.GetKey(KeyCode.D))
            tiltInput -= 1f;

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
        
        
        float targetAngle = tiltInput * tiltSpeed;


        // Applied
        transform.rotation = Quaternion.Euler(0f, 0f, targetAngle);

    }

    // Calculate a vector for the input in the Y for Up/Down.
    private void MoveMap(float moveInput)
    {
       
        Vector3 movement = new Vector3(0f, moveInput, 0f) * moveSpeed * Time.deltaTime;

        // Applied
        transform.Translate(movement);
    }
}
