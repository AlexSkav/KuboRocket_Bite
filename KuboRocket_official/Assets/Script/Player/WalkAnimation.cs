using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimation : MonoBehaviour
{

    Animator Jump;
    //bool Jump;


    // Start is called before the first frame update
    void Start()
    {
        Jump = GetComponent<Animator>();
        //Jump.SetBool("Jump", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("ground"))
        {
            Debug.Log("sono a terra !!!!!");
            Jump.SetBool("Jump", false);
            //Jump.enabled = true;
               
        }
        //else 
        //{
        //    Debug.Log("ARIAAAA");
        //    Jump.SetBool("Jump", false);
        //}

    }

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    Debug.Log("SONO IN ARIAAAA");
    //    Jump.SetBool("Jump", false);
    //}

}
