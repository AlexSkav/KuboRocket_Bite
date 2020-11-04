using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollEnemy2 : MonoBehaviour
{
    public float vel = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scorrimento();
    }

    void scorrimento(){
        transform.Translate(Vector2.down * vel * Time.deltaTime);
    }
}
