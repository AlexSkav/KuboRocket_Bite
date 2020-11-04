using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    
    private Animator anim;
    private Collider2D collider2d;

    void Start()
    {
        anim = GetComponent<Animator>();
        collider2d = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("ground"))
        {
            
            anim.SetBool("isIdle", false);
            anim.SetBool("isRunning", true);
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    { 
        anim.SetBool("isRunning", false);
        anim.SetBool("isJumping", true);
    }

}
