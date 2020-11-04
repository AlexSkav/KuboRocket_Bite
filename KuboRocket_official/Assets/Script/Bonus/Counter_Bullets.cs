using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Counter_Bullets : MonoBehaviour
{
    public Text bulletCounter;
    public Player2Controller player;
    // Start is called before the first frame update
    void Start()
    {
        bulletCounter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletCounter.text = player.muni.ToString() ;
    }
}
