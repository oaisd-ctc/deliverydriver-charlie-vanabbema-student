using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IncreaseLevel : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    void OnTriggerEnter2D(Collider2D other) 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sortingOrder += 1;
        // if(other.tag == "Player")
        // {
        //      = GetComponent<SpriteRenderer>();
        // }
        // else
        // {
            
        // }
    }
}

