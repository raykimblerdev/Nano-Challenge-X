using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private float swingDuration = 0.1f;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("a collision is you");
        //Debug.Log("collision name is " + collision.collider.name);
        //Debug.Log("other collision name is " + collision.otherCollider.name);
        Destroy(collision.gameObject);
    }
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if(swingDuration > 0){
            swingDuration -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
