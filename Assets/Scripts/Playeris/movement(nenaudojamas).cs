using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class movement: MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput * speed; 
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    /*void ProcessInputs()
    {
        float Input.GetAxisRaw("Horizontal")
        float moveY = InputAxisRaw("Vertical")
            moveDiretion = new Vector2(moveX, moveY)
    }*/

}
