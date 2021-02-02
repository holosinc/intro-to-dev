using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float speed = 9.0f;
    private float startPosition;

    void Start()
    {
        startPosition = transform.position.y+1;
    }

    void Update()
    {
        // Update only the y position based on the sine wave so the character oscillates between 0 and 1
        transform.position = new Vector3(transform.position.x, startPosition + Mathf.Sin(Time.time * speed), transform.position.z);
    }
}
