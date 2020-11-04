using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMulti : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject rettangolo1;//spawn nemici fermi
    public GameObject rettangolo2;//spawn nemici in movimento
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
                    GameObject newrettangolo1 = Instantiate(rettangolo1);//fermi
                    newrettangolo1.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);
                    timer = 0;
                    Destroy(newrettangolo1, 8f); 
                    break;
                case 2:
                    GameObject newrettangolo2 = Instantiate(rettangolo3);//munizioni
                    newrettangolo2.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);
                    timer = 0;
                    Destroy(newrettangolo2, 8f);
                    break;
                case 3:
                    GameObject newrettangolo3 = Instantiate(rettangolo2);//in movimento
                    newrettangolo3.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);
                    timer = 0;
                    Destroy(newrettangolo3, 8f);
                    break;
                case 4:
                    GameObject newrettangolo4 = Instantiate(rettangolo2);//in movimento
                    newrettangolo4.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);
                    timer = 0;
                    Destroy(newrettangolo4, 8f);
                    break;
                case 5:
                    GameObject newrettangolo5 = Instantiate(rettangolo1);//fermi
                    newrettangolo5.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);
                    timer = 0;
                    Destroy(newrettangolo5, 8f); 
                    break;
                case 6:
                    GameObject newrettangolo6 = Instantiate(rettangolo1);//fermi
                    newrettangolo6.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);
                    timer = 0;
                    Destroy(newrettangolo6, 8f); 
                    break;
                case 7:
                    GameObject newrettangolo7 = Instantiate(rettangolo2);//in movimento
                    newrettangolo7.transform.position = transform.position + new Vector3(Random.Range(minimo, massimo), 0, 0);
                    timer = 0;
                    Destroy(newrettangolo7, 8f);
                    break;
            }
        }
        timer += Time.deltaTime;
    }
}
