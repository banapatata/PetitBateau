using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setGameOver : MonoBehaviour {
    [SerializeField]
    private Text GameOverText;

    private bool isAlive = true;
        
    // Use this for initialization
    void Start () {
        GameOverText.text = "";
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("space") && !isAlive)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void GameOver()
    {
		scoring.updateScore ();
		GameOverText.text = "Game Over \nPush space\n\nScore : " + scoring.score+"\nHigh Score : "+scoring.highscore;
        isAlive = false;
    }

    public bool getIsAlive()
    {
        return isAlive;
    }
}
