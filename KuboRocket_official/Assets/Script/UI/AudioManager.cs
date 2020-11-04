using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    AudioSource audioS;
    public GameObject obj;
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        audioS.Play(0);
    }

    private void Update()
    {
        if (!obj.activeSelf)
        {           
            audioS.Stop();
        }

    }



}
