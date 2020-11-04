using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeButton : MonoBehaviour
{
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Button but;


    private void Awake()
    {
        if (AudioListener.pause)
        {
            but.image.sprite = OffSprite;
        }
    }

    public void VolumeButtonImageChange()
    {
        //BUTTON GOES OFF
        if (but.image.sprite == OnSprite)
        {
            AudioListener.pause = !AudioListener.pause;
            but.image.sprite = OffSprite;
        } else  //BUTTON GOES ON
        {
            AudioListener.pause = !AudioListener.pause;
            but.image.sprite = OnSprite;
        }
    }
}
