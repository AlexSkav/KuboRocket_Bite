using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    private float giusta_x = 0.6f;
    //public Transform pistola;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.position.x+giusta_x,player.position.y+2);
    }
}
