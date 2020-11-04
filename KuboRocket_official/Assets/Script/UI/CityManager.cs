using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CityManager : MonoBehaviour
{
    public GameObject Rome;
    public GameObject Paris;
    public GameObject DefaultCity;
    
    public static string city /*= "default" */;  // da controllare !!!!!
    

    private void Awake()
    {
        //string city = (ShopButtonManager.city);
        //Debug.Log(city);
        if (city == "Rome")
        {
            Rome.SetActive(true);
            DefaultCity.SetActive(false);
            Paris.SetActive(false);
        } else if (city == "Paris")
        {
            Rome.SetActive(false);
            DefaultCity.SetActive(false);
            Paris.SetActive(true);

        } else if (city == "Default")
        {
            Rome.SetActive(false);
            DefaultCity.SetActive(true);
            Paris.SetActive(false);
        }


    }
}