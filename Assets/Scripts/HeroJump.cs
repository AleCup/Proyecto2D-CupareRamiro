using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroJump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 500f; //fuerza que se aplica al saltar
    private bool isGrounded;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            JumpPlayer();
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
    public void JumpPlayer()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
