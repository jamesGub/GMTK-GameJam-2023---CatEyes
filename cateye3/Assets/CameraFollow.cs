using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    private Vector3 offset;


    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
