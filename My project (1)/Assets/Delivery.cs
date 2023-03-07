using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You hit something!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package")
        {
            Debug.Log("Package picked up!");
        }
    }
}
