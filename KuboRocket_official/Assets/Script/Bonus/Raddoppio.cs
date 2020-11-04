using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raddoppio : MonoBehaviour
{
    public PlayerController player;
    public GameObject raddoppio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void raddoppioMonete()
    {
        player.monete = player.monete * 2;
        raddoppio.SetActive(false);
    }

}
