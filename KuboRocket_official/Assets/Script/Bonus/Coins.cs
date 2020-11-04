using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    //private void OnTriggerEnter2D(Collision2D collision)
    //{
       
    //    if (collision.transform.CompareTag("Player"))
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("moneta");
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("moneta");
        }
    }
}
