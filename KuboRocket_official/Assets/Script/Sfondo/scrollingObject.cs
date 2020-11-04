using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingObject : MonoBehaviour
{
    private Rigidbody2D sfondo;
    public float scrollSpeedX = -1.5f;

    public float scrollSpeedY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        sfondo = GetComponent<Rigidbody2D>();
        sfondo.velocity = new Vector2(scrollSpeedX, scrollSpeedY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
