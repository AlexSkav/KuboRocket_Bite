using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject coin;
    public float massimo;
    public float minimo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newcoin = Instantiate(coin);
            newcoin.transform.position = transform.position + new Vector3(0, Random.Range(minimo, massimo), 0);
            //newcoin.transform.position = transform.position + new Vector3(2, 0, 0);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
