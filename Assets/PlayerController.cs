using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float moveSpeed = 5f;
    public Hook hook;
    Vector2 moveDirection;
    Vector2 mousePosition;
    public float timeBeforeSwing = 0;

    private bool isHookFired = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        if (timeBeforeSwing > 0)
            {
                timeBeforeSwing -= Time.deltaTime;
            }
        if(Input.GetMouseButton(0) && timeBeforeSwing <= 0)
        {
            
            hook.SwingSword();
            timeBeforeSwing = 0.3f;
        }

        if(Input.GetKeyDown("space") && !(isHookFired))
        {
            //Debug.Log("player controller works");
            hook.Fire();
            //isHookFired = true;
            
        }

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = aimAngle;
    }
}
