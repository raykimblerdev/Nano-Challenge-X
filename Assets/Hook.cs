using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public GameObject swordPrefab;
    public GameObject hookPrefab;
    public Transform firePoint;
    public float swingForce = 10f;
    public float hookSpeed = 30f;

    // Start is called before the first frame update
    public void Fire()
    {
        //Debug.Log("hook controller works");
        GameObject hook = Instantiate(hookPrefab, firePoint.position, firePoint.rotation);
        hook.GetComponent<Rigidbody2D>().AddForce(firePoint.up * hookSpeed, ForceMode2D.Impulse);
    }
    public void SwingSword()
    {
        GameObject sword = Instantiate(swordPrefab, firePoint.position, firePoint.rotation);
        sword.GetComponent<Rigidbody2D>().AddForce(firePoint.right * swingForce, ForceMode2D.Impulse);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
