using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float speed = 8f;
    private float jumpingPower = 16f;
    

    

    

    

    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        print("A and D to Move / Space to Jump / LeftShift to Dash / RightMouseButton to Shoot (volume warning)");
    }

    void Update()
    {
        
        //Movement input
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //Jump
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

    }


    private void FixedUpdate()
    {
        

        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }



    

    
}
