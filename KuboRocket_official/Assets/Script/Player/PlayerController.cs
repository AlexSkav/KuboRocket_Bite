using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject moneta;
    Rigidbody2D rb;
    public float speed;
    public int score = 0;
    public int monete = 0;
    public GameObject gameOverUI;
    public GameObject pause;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        rb.velocity = Vector2.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("enemy")) 
        {
            gameOverUI.SetActive(true);
            pause.SetActive(false);
            Time.timeScale = 0f;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("score"))
        {
            score += 1;
            if (score > PlayerPrefs.GetInt("BestScore", 0)) {
                PlayerPrefs.SetInt("BestScore", score);
            }
            Debug.Log(score);
        }
        else if (collision.transform.CompareTag("coin"))
        {
            monete += 1;
            Debug.Log("moneta");
        }
    }


}
