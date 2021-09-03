using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rB2D;

    [Header("Player Speed and Jump")]
    public float runSpeed;
    public float jumpSpeed;
    public bool jump = true;
    public bool turn = false;

    public SpriteRenderer spriteRenderer;
    public Animator animator;

    private void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            
            int levelMask = LayerMask.GetMask("Level");

            if (Physics2D.BoxCast(transform.position, new Vector2(1f, .1f), 0f, Vector2.down, .01f, levelMask))
            {
                Jump();
                Debug.Log("Jump Test");
            }
            
        }
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal") ;

        rB2D.velocity = new Vector2(horizontalInput * runSpeed * Time.deltaTime, rB2D.velocity.y);

        animator.SetFloat("Running", Mathf.Abs(horizontalInput));

        if (rB2D.velocity.x > 0)
        {
            spriteRenderer.flipX = false;
            turn = false;
        }
        else
        if (rB2D.velocity.x < 0)
        {
            spriteRenderer.flipX = true;
            turn = true;
        }
        }
    void Jump()
    {
        rB2D.velocity = new Vector2(rB2D.velocity.x, jumpSpeed);
    }

}
