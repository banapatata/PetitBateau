using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollEnemi : MonoBehaviour {
	AudioSource audio;

	void Start () {
		audio = GetComponent <AudioSource> ();
	}

    void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag == "Enemi")
        {
			audio.Play ();
			GameObject.FindGameObjectWithTag("GameController").GetComponent<setGameOver>().GameOver(); 
        } 
    }
}
    