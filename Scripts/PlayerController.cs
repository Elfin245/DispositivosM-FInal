using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput.PlatformSpecific;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    public float speed, jumpS;
    float velX, velY,jump;
    public Joystick joy;
    Rigidbody2D rb;
    public Transform Check;
    public bool isgrounded;
    public float Checkradius;
    public LayerMask whatisground;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        isgrounded = Physics2D.OverlapCircle(Check.position, Checkradius, whatisground);
        if (isgrounded)
        {
            anim.SetBool("Saltar", false);
        }
        else
        {
            anim.SetBool("Saltar", true);
        }
        Attack();

    }
    public void FixedUpdate()
    {

        Movement();
        Jump();
        Flip();
    }

    public void Movement()
    {
        velX = joy.Horizontal* speed;
        velY = rb.velocity.y;
        rb.velocity = new Vector2(velX * speed, velY);
        jump = joy.Vertical * speed;

        if (rb.velocity.x!=0)
        {
            anim.SetBool("Caminar", true);
        }
        else
        {
            anim.SetBool("Caminar", false);
        }

    }

    public void Flip()
    {
        if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(rb.velocity.x<0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    public void Jump()
    {
        if (jump>=.2f&&isgrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x * speed, jumpS);
        }
    }
    public void Attack()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            anim.SetBool("Atack", true);
        }
        else
        {
            anim.SetBool("Atack", false);
        }

    }

}
