using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
	private float now;
	private float xModifier = 12.0f;
	private float yModifier = 5.0f;
	private int lastRand = 0;

	private int nbcases = 13;

    [SerializeField]
    private float timerSpawn;
	[SerializeField]
	private GameObject Rock;
	[SerializeField]
	private GameObject Bird;

	// Use this for initialization
	void Start () {
		now = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (now + timerSpawn < Time.time) {
			int rand = (int)(Random.value *nbcases);

			// pour eviter d'avoir deux fois le meme patern a la suite
			if (rand == lastRand)
				rand = (rand+1)%nbcases;
			
			now = Time.time;
			lastRand = rand;
			
			spawnRocks (rand);
		}
	}

	void spawnRocks(int rand){
		switch (rand) {
		case 0:
			Instantiate (Rock, new Vector2 (xModifier, (int)(Random.value * 9)+1-yModifier), Quaternion.identity);
			break;
		case 1:
			Instantiate (Rock, new Vector2 (xModifier, 6.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 9.0f - yModifier), Quaternion.identity);
			break;
		case 2:
			Instantiate (Rock, new Vector2 (xModifier, 2.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 8.0f-yModifier), Quaternion.identity);
			break;
		case 3:
			Instantiate (Rock, new Vector2 (xModifier, 3.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 4.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 5.0f-yModifier), Quaternion.identity);
			break;
		case 4:
			Instantiate (Rock, new Vector2 (xModifier, 4.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 7.0f-yModifier), Quaternion.identity);
			break;
		case 5:
			Instantiate (Rock, new Vector2 (xModifier, 1.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 2.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 5.0f-yModifier), Quaternion.identity);
			break;
		case 6:
			Instantiate (Rock, new Vector2 (xModifier, 1.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 5.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 8.0f-yModifier), Quaternion.identity);
			break;
		case 7:
			Instantiate (Rock, new Vector2 (xModifier, 1.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 2.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 3.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 7.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 8.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 9.0f-yModifier), Quaternion.identity);
			break;
		case 8:
			Instantiate (Rock, new Vector2 (xModifier, 2.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 3.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 6.0f-yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 9.0f-yModifier), Quaternion.identity);
			break;
		case 9:
			Instantiate (Rock, new Vector2 (xModifier, (int)(Random.value * 9)+1-yModifier), Quaternion.identity);
			break;
		case 10:
			Instantiate (Rock, new Vector2 (xModifier, 9.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 8.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 1.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 2.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 3.0f - yModifier), Quaternion.identity);

			Instantiate (Rock, new Vector2 (1.0f + xModifier, 7.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (1.0f + xModifier, 2.0f - yModifier), Quaternion.identity);

			Instantiate (Rock, new Vector2 (2.0f + xModifier, 6.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (2.0f + xModifier, 1.0f - yModifier), Quaternion.identity);

			Instantiate (Rock, new Vector2 (3.0f + xModifier, 5.0f - yModifier), Quaternion.identity);
			now = now+2;
			break;
		case 11:
			Instantiate (Rock, new Vector2 (xModifier, 9.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 8.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 7.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 1.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (xModifier, 2.0f - yModifier), Quaternion.identity);

			Instantiate (Rock, new Vector2 (1.0f + xModifier, 8.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (1.0f + xModifier, 3.0f - yModifier), Quaternion.identity);

			Instantiate (Rock, new Vector2 (2.0f + xModifier, 9.0f - yModifier), Quaternion.identity);
			Instantiate (Rock, new Vector2 (2.0f + xModifier, 4.0f - yModifier), Quaternion.identity);

			Instantiate (Rock, new Vector2 (3.0f + xModifier, 5.0f - yModifier), Quaternion.identity);
			now = now+2;
			break;
		case 12:
			Instantiate (Bird, new Vector2 (1.0f + xModifier, (int)(Random.value * 4) + 3 - yModifier), Quaternion.identity);
			now = now + 1.5f;
			break;
		}
	}
}
