using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScore : MonoBehaviour
{
    Text scoreValue;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue.text = /*"SCORE\n" + */ player.score.ToString();

    }
}
