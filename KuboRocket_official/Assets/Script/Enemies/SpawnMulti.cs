using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMulti : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject nemico1;//spawn nemici
    public GameObject nemico2;//spawn nemici
    public GameObject nemico3;//spawn nemici
    public GameObject nemico4;//spawn nemici
    public GameObject rettangolo3;//Spawn munizioni per terra
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
            //spawn nemici e munizioni totalmente casuale
            switch (Random.Range(1,8)){
                case 1:
                    GameObject newnemico1 = Instantiate(nemico1);
                    newnemico1.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), -1, 0);
                    timer = 0;
                    Destroy(newnemico1, 8f);
                    break;
                case 2:
                    GameObject newrettangolo2 = Instantiate(rettangolo3);//munizioni
                    newrettangolo2.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), -1, 0);
                    timer = 0;
                    Destroy(newrettangolo2, 8f);
                    break;
                case 3:
                    GameObject newnemico2 = Instantiate(nemico2);
                    newnemico2.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), -1, 0);
                    timer = 0;
                    Destroy(newnemico2, 8f);
                    break;
                case 4:
                    GameObject newnemico3 = Instantiate(nemico3);
                    newnemico3.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), -1, 0);
                    timer = 0;
                    Destroy(newnemico3, 8f);
                    break;
                case 5:
                    GameObject newnemico4 = Instantiate(nemico4);
                    newnemico4.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), -1, 0);
                    timer = 0;
                    Destroy(newnemico4, 8f); 
                    break;
                case 6:
                    GameObject newnemico5 = Instantiate(nemico1);
                    newnemico5.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), -1, 0);
                    timer = 0;
                    Destroy(newnemico5, 8f); 
                    break;
                case 7:
                    GameObject newnemico6 = Instantiate(nemico4);
                    newnemico6.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), -1, 0);
                    timer = 0;
                    Destroy(newnemico6, 8f);
                    break;
                case 8:
                    GameObject newnemico7 = Instantiate(nemico3);
                    newnemico7.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), -1, 0);
                    timer = 0;
                    Destroy(newnemico7, 8f);
                    break;
            }
        }
        timer += Time.deltaTime;
    }
}
