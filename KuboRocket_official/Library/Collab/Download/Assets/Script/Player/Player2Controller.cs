using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    Rigidbody2D body;
    public float speed = 5f;
    public GameObject gameOverUI;
    public GameObject pause;
    public int muni = 3;    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        //proiettile = GameObject.FindWithTag("proiettile");
    }

    // Update is called once per frame
    void Update() 
    {
        movimento_laterale();
        //if (muni == 0) { 
            
        //}
    }

    void movimento_laterale(){
        //prende tutti gli input sull'asse orizzontale
        float a = Input.GetAxisRaw("Horizontal"); 
        //vettore che prende l'asse x dell'input preso in precedenza
        Vector2 mov = new Vector2(a,0);

        //aggiunge alla posizione del rigidbody il vettore preso in precedenza (+ mov.normalized)
        body.MovePosition(body.position + mov.normalized * Time.deltaTime * speed);

        //oppure

        // if(Input.GetKeyDown(KeyCode.RightArrow)){
        //     transform.Translate(Vector2.right * speed * Time.deltaTime);
        // }

        // if(Input.GetKeyDown(KeyCode.LeftArrow)){
        //     transform.Translate(Vector2.left * speed * Time.deltaTime);
        // }
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     sparo();
        // }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.CompareTag("enemy")){
            gameOverUI.SetActive(true);
            pause.SetActive(false);
            Time.timeScale = 0f;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("proiettile"))
        {
            muni ++;
            //Debug.Log(muni);
            
        }
        
    }
}
