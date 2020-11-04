using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomESparo : MonoBehaviour
{
    public GameObject proiettile;
    public Player2Controller player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sparo();
    }

    void sparo(){
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject newproiettile = Instantiate(proiettile);
            newproiettile.transform.position = player.transform.position;
        }
    }
    
}
