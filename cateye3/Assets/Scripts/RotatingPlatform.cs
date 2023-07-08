using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float rotationSpeed = 10f;

    // Update is called once per frame
    private void Update()
    {
      transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);  
    }
}
