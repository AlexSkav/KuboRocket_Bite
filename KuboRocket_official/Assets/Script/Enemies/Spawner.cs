using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject rettangolo;
    public float massimo;
    public float minimo;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newrettangolo = Instantiate(rettangolo);
        newrettangolo.transform.position = transform.position + new Vector3(0, Random.Range(minimo, massimo), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newrettangolo = Instantiate(rettangolo);
            newrettangolo.transform.position = transform.position + new Vector3(0, Random.Range(minimo, massimo), 0);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

}
