﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{

    public GameObject pause;
    public GameObject stopGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resume()
    {
        stopGroup.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 1f;
    }

}
