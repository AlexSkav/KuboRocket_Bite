using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAnimPlayer : MonoBehaviour
{

    private bool isGrounded;

    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("ground"))
        {
            anim.SetBool("isGrounded", true);
        }
    }

    void Update()
    {
        
    }
}
