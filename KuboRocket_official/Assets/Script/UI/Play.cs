using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    public GameObject menu;
    public GameObject pause;
    public GameObject score;
    public GameObject bestScore;
    public GameObject counterMonete;

    private void Start()
    {
        if (menu.activeSelf == true)
        {
            Time.timeScale = 0f;
        }
    }

    public void play()
    {
        menu.SetActive(false);
        pause.SetActive(true);
        score.SetActive(true);
        bestScore.SetActive(false);
        counterMonete.SetActive(true);
        Time.timeScale = 1f;
    }
}
