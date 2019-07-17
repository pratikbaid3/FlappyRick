using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour 
{
    [SerializeField]
    private GameObject ground;
    [SerializeField]
    private float _speed=0.05f;

    private PlayerMovement _player;

    private bool spawn =false;
    private bool delete =false;
    // Update is called once per frame
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    void Update () 
    {
        if (_player.gameOver==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * (2.5f));
            //transform.Translate(Vector3.up * vertical * Time.deltaTime * speed);
            if (transform.position.x <= -2.21f && spawn == false)
            {
                Instantiate(ground, new Vector3(8.5f, -4.73f, 0), Quaternion.identity);
                spawn = true;
            }
            if (transform.position.x <= -8.5f && delete == false)
            {
                Destroy(this.gameObject);
                delete = true;
            }
        }
	}
}
