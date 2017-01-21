using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoring : MonoBehaviour {

	static public int highscore = 0;
	static public int score = 0;
	// Use this for initialization
	void Start () {
		highscore = PlayerPrefs.GetInt ("High Score", 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (score > highscore && !GameObject.FindGameObjectWithTag ("GameController").GetComponent<setGameOver> ().getIsAlive ()) {
			PlayerPrefs.SetInt ("High Score", score);
			score = 0;
		}
	}
}
