using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject cloud;

    private PlayerMovement _player;

    private bool spawn = false;
    private bool delete = false;
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    void Update () 
    {
        if(_player.gameOver==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            if (transform.position.x <= -0.14f && spawn == false)
            {
                Instantiate(cloud, new Vector3(6.13f, 1.77f, 0f), Quaternion.identity);
                spawn = true;
            }
            if (transform.position.x <= -6.11f && delete == false)
            {
                Destroy(this.gameObject);
                delete = true;
            }
        }
	}
}
