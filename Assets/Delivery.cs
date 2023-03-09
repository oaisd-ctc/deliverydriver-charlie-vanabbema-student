using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    [SerializeField] Color32 hasPackageColor = new Color32 (13, 226, 245, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (255, 0, 255, 255);
    [SerializeField] float destroydelay = 0.1f;
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You hit something!");
        
    }
   


    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroydelay);
        }

        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
