using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    string highScore;
    Text bestScore;

    // Start is called before the first frame update
    void Start()
    {
        bestScore = GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("BestScore", 0).ToString();
        bestScore.text = "\nBEST SCORE: " + highScore;
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetInt("BestScore", 0).ToString();
        bestScore.text = "BEST SCORE: " + highScore;
    }
}
