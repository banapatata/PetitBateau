using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	private float now;
	private float xModifier = 12.0f;
	private float yModifier = 5.0f;
	private int lastRand = 0;

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

			if (rand == lastRand)
				rand = (rand+1)%7;

			lastRand = rand;
			
			spawnRocks (rand);
			now = Time.time;
		}
	}

	void spawnRocks(int rand){
		float distance = Camera.main.ScreenToWorldPoint(new Vector2(0.0f,Screen.height)).y / 5;
		switch (rand) {
		case 0:
			Instantiate (Rocher, new Vector2 (xModifier, Random.value * 9 * distance-4.5f), Quaternion.identity);
			break;
		case 1:
			Instantiate (Rocher, new Vector2 (xModifier, 7.0f * distance-yModifier), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (xModifier, 9.0f * distance-yModifier), Quaternion.identity);
			break;
		case 2:
			Instantiate (Rocher, new Vector2 (xModifier, 2.0f * distance-yModifier), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (xModifier, 8.0f * distance-yModifier), Quaternion.identity);
			break;
		case 3:
			Instantiate (Rocher, new Vector2 (xModifier, 3.0f * distance-yModifier), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (xModifier, 4.0f * distance-yModifier), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (xModifier, 5.0f * distance-yModifier), Quaternion.identity);
			break;
		case 4:
			Instantiate (Rocher, new Vector2 (xModifier, 6.0f * distance-yModifier), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (xModifier, 8.0f * distance-yModifier), Quaternion.identity);
			break;
		case 5:
			Instantiate (Rocher, new Vector2 (xModifier, 2.0f * distance-yModifier), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (xModifier, 5.0f * distance-yModifier), Quaternion.identity);
			break;
		case 6:
			Instantiate (Rocher, new Vector2 (xModifier, 1.0f * distance-yModifier), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (xModifier, 5.0f * distance-yModifier), Quaternion.identity);
			Instantiate (Rocher, new Vector2 (xModifier, 8.0f * distance-yModifier), Quaternion.identity);
			break;
		}
	}
}
