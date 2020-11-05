using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    private bool touched = true;
    //false = destra, true = sinistra
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
        if (touched == false)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("barriera") || col.transform.CompareTag("enemy"))
        {
            //Debug.Log("HO PRESO IL MURO FRATELLI'");
            if (touched == false)
            {
                touched = true;
            }else
            {
                touched = false;
            } 
        }
        
    }
}
