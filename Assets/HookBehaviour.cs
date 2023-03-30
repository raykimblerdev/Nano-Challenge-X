using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private GameObject box;
    public float dragSpeed = 1f;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        //run code to drag back the box
        //take the collider, apply a force 
        //transform position * speed * delta time on a fixed update
        box = collision.gameObject;
        Destroy(collision.otherCollider.gameObject);
        
    }

    void FixedUpdate()
    {
        
    }
    
}
