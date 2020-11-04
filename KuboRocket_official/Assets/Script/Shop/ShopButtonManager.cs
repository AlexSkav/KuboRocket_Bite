using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButtonManager : MonoBehaviour
{
    [SerializeField] public string cityInput;
    public void ButtonMoveScene(string cityInput)
    {
        SceneManager.LoadScene("game");
        (CityManager.city) = cityInput;
        
    }

    
    
}
