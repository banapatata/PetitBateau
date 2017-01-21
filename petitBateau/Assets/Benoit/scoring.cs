using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoring : MonoBehaviour {

	static public int highscore = 0;
	static public int score = 0;
	// Use this for initialization
	void Start () {
		highscore = PlayerPrefs.GetInt ("High Score", 0);
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	static public void updateScore(){
		if (score > highscore) {
			PlayerPrefs.SetInt ("High Score", score);
			highscore = score;
		}
	}
}
