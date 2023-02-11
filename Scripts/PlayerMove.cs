using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator animator; 
    public float PlayerSpeed = 0.1f;
    Rigidbody2D rb;
    public float jump = 5f;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        transform.Translate(xInput*PlayerSpeed, 0f, 0f);
        animator.SetFloat("Speed", xInput);
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
}
