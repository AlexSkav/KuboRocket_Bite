using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;
    private bool touched = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimento();
    }

    void movimento(){
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.CompareTag("barriera"))
        {
            Debug.Log("colpito");
            //touched = false;
            //if (touched == false)
            //{
            //    transform.Translate(Vector2.left * speed * Time.deltaTime);
            //}else
            //{
            //    transform.Translate(Vector2.right * speed * Time.deltaTime);
            //} 
            //touched = true;
        }
        
    }
}
