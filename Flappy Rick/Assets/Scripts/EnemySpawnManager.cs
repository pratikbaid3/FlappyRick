using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour 
{
    [SerializeField]
    private GameObject _Enemy;

    private bool _Spawned = false;

    private PlayerMovement _player;

    IEnumerator spawnEnemy()
    {
        Instantiate(_Enemy, new Vector3(4f, Random.Range(-1.54f, 2.3f), 0), Quaternion.identity);
        yield return new WaitForSeconds(2f);
        //Debug.Log("Spawn Enemy");
        _Spawned = false;
    }
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    void Update () 
    {
        if(_player.gameOver==false)
        {
            if (_Spawned == false)
            {
                _Spawned = true;
                StartCoroutine("spawnEnemy");
            }
        }
	}
}
