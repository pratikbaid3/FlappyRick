using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
    [SerializeField]
    private Text pointsText;

    private int _points;

    private PlayerMovement _player;

	// Use this for initialization
	void Start () 
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        pointsText.text = "POINTS: 0";
	}
	
	// Update is called once per frame
	void Update () 
    {
        pointsText.text = "POINTS: "+_player.score;
	}
}
