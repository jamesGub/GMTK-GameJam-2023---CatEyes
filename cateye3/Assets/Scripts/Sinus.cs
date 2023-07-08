using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinus : MonoBehaviour
{

    public float amplitude = 1f;
    public float frequency = 1f;
    public float speed = 1f;

    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;

        transform.position = new Vector3(startPosition.x, newY, startPosition.z);    }
}
