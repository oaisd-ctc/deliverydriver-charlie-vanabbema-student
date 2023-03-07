using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 15f;
    // public SpriteRenderer spriteRenderer;
    // public Vector3 setPosition;

    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = 35f;
            steerSpeed = 500f;
        }
        if(other.tag == "HighRoad")
        {
            Vector3 position = transform.position;
            position.z = -10;
            transform.position = position;
            // transform.Translate(0, 0, 10);
        }
        else if(other.tag == "MidRoad"&& other.tag == "Highroad")
        {
            Vector3 position = transform.position;
            position.z = 0;
            transform.position = position;
            // transform.Translate(0, 0, 0);
        }
        else if(other.tag == "MidRoad")
        {
            Vector3 position = transform.position;
            position.z = 0;
            transform.position = position;
            // transform.Translate(0, 0, 0);
        }
        else if(other.tag == "LowRoad")
        {
            Vector3 position = transform.position;
            position.z = 5;
            transform.position = position;
            // transform.Translate(0, 0, 10);
        }
    }

    // void RaiseElevation(bool x)
    // {
    //     if (x)
    //     {
    //         transform.Translate(0, 0, 1);
    //     }
    // }
}
