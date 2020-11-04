using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject rettangolo1;
    public float massimo;
    public float minimo;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newrettangolo1 = Instantiate(rettangolo1);
        newrettangolo1.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newrettangolo1 = Instantiate(rettangolo1);
            newrettangolo1.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);            
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
