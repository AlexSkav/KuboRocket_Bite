using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSfondo2 : MonoBehaviour
{
    public float scroll = 1.5f;
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
        transform.Translate(Vector2.down * scroll * Time.deltaTime);
    }
}
