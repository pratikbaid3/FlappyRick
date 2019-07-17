using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{
    private bool scorer = false;
    private PlayerMovement _player;
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    void Update () 
    {
        if(_player.gameOver==false)
        {
            if (transform.position.x <= -2.83f && scorer == false)
            {
                scorer = true;
                _player.score++;
                Debug.Log("SCORE: " + _player.score);
            }
            transform.Translate(Vector3.left * Time.deltaTime*(2.5f));
            if(transform.position.x<-3.6f)
            {
                Destroy(this.gameObject);
            }
        }
	}
}
