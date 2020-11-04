using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstagramLink : MonoBehaviour
{
    public PlayerPrefs soldiPresi;
    public GameObject instagramLink;
    private Text testoBottone;
    // Start is called before the first frame update

    void Start()
    {
        PlayerPrefs.SetInt("soldiPresi", 0);
        testoBottone = instagramLink.GetComponent<Text>();
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("soldiPresi", 0) == 0)
        {
            testoBottone.text = "+50 FOR FREE";
        } 
        else
        {
            testoBottone.text = "";
        }

    }

    public void OpenUrl()
    {
        Application.OpenURL("https://www.instagram.com/bitevideogames/");
        if (PlayerPrefs.GetInt("soldiPresi", 0) == 0)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) + 50);
        }
        PlayerPrefs.SetInt("soldiPresi", 1);
    }
}
