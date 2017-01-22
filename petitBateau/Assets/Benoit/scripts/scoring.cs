using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour {

	[SerializeField]
	private Text ScoreText;

	static public int highscore = 0;
	static public int score = 0;
	// Use this for initialization
	void Start () {
		highscore = PlayerPrefs.GetInt ("High Score", 0);
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(ScoreText!=null) ScoreText.text = "Score : " + scoring.score;
		if (!GameObject.FindGameObjectWithTag("GameController").GetComponent<setGameOver>().getIsAlive()) ScoreText.text = "";
	}

	static public void updateScore(){
		if (score > highscore) {
			PlayerPrefs.SetInt ("High Score", score);
			highscore = score;
		}
	}
}
