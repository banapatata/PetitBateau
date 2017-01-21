using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]

public class waveBehavior : MonoBehaviour {

	Rigidbody2D rb;
	private Vector2 direction;
	float spawnTime;
	public float ttl = 2;

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
		initMove (direction);
		Destroy (gameObject, ttl);
	}

	void Update () {
	}

	public void initMove (Vector2 vector) {
		Debug.Log ("vector : " + vector);
		if (vector.magnitude < 1f) {
			vector.Normalize ();
		} else if (vector.magnitude > 10f) {
			vector.Normalize ();
			vector *= 10f;
		}
		Debug.Log ("vector after normalized : " + vector);
		transform.up = vector;
		rb.AddForce (vector, ForceMode2D.Impulse);
	}

	public void setDirection (Vector2 newDirection) {
		direction = newDirection;
	}

	public Vector2 getDirection () {
		return direction;
	}
}