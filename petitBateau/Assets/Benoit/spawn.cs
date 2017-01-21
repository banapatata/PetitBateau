using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	private float now;

	[SerializeField]
	private float timerSpawn;

	[SerializeField]
	private GameObject Rocher;

	// Use this for initialization
	void Start () {
		now = Time.time;
		Instantiate (Rocher);
	}
	
	// Update is called once per frame
	void Update () {
		if (now + timerSpawn < Time.time) {
			int rand = (int)(Random.value *7);
			spawnRocks (rand);
			now = Time.time;
		}
	}

	void spawnRocks(int rand){
		float distance = Camera.main.ScreenToWorldPoint(new Vector2(0.0f,Screen.height)).y / 10;
		Debug.Log (rand);
		switch (rand) {
		case 0:
			Instantiate (Rocher, new Vector2 (0.0f, 3 * distance), Quaternion.identity);
			break;
		case 1:
			Instantiate (Rocher, new Vector2 (0.0f, 7 * distance), Quaternion.identity);
			break;
		case 2:
			Instantiate (Rocher, new Vector2 (0.0f, 2 * distance), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (0.0f, 8 * distance), Quaternion.identity);
			break;
		case 3:
			Instantiate (Rocher, new Vector2 (0.0f, 3 * distance), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (0.0f, 4 * distance), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (0.0f, 5 * distance), Quaternion.identity);
			break;
		case 4:
			Instantiate (Rocher, new Vector2 (0.0f, 6 * distance), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (0.0f, 8 * distance), Quaternion.identity);
			break;
		case 5:
			Instantiate (Rocher, new Vector2 (0.0f, 2 * distance), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (0.0f, 5 * distance), Quaternion.identity);
			break;
		case 6:
			Instantiate (Rocher, new Vector2 (0.0f, 1 * distance), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (0.0f, 5 * distance), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (0.0f, 8 * distance), Quaternion.identity);
			break;
		}
	}
}
