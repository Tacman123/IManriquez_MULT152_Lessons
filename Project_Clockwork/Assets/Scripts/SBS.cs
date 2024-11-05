using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBS : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 100.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float horizontalInput = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Translate(0, 0, verticalInput);
        transform.Rotate(0, horizontalInput, 0);
    }
}
