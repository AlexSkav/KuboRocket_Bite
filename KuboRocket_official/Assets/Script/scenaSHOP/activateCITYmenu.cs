using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateCITYmenu : MonoBehaviour
{
    public GameObject Scene;
    public GameObject choose;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void city_Scene()
    {
        Scene.SetActive(true);
        choose.SetActive(false);
        // gameObject.SetActive(false);
    }
}
