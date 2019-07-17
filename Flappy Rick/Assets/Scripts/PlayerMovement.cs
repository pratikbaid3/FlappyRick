using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    private Rigidbody2D rb2D;
    public bool gameOver = false;
    public int score;
    // Update is called once per frame
    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update () 
    {
        if (Input.GetKeyDown("space"))
        {
            rb2D.AddForce(transform.up * (0.015f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 10f;
            Debug.Log("LOST");
            gameOver = true;
        }
    }
}
