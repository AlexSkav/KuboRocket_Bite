using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject menu;
    public GameObject pause;
    public GameObject stopGroup;

    private void Start()
    {

    }


    void Update()
    {
        //Il bottone pausa si disattiva e attiva a seconda della presenza del menu
        //if (menu.activeSelf == true)
        //{
        //    pause.SetActive(false);
        //}
    }

    //Per fermare il gioco
    public void stop()
    {
        Time.timeScale = 0f;
        pause.SetActive(false);
        stopGroup.SetActive(true);
    }
}
