using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text coinCounter;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        coinCounter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = player.monete.ToString() + " $";
    }
}
