using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
[RequireComponent (typeof(Animator))]

public class waveBehavior : MonoBehaviour {

	Rigidbody2D rb;
	private Vector2 direction;
	float spawnTime;
	bool boatAlreadyTouched = false;

	// *** Variables modifiables ***
	private float ttl = 2;
	private float power = 1;
	private float minForce = 1f;
	private float maxForce = 10f;
	private float maxSize = 1;
	// ***

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
		InitMove (direction);
		Destroy (gameObject, ttl);
	}

	void Update () {
	}

	public void InitMove (Vector2 vector) {
		if (vector.magnitude < minForce) {
			vector.Normalize ();
		} else if (vector.magnitude > maxForce) {
			vector.Normalize ();
			vector *= maxForce;
		}
		vector *= power;
		transform.right = vector;
		rb.AddForce (vector, ForceMode2D.Impulse);
	}

	public void setDirection (Vector2 newDirection) {
		direction = newDirection;
	}

	public Vector2 getDirection () {
		return direction;
	}

	public void setBoatAlreadyTouched (bool touched) {
		boatAlreadyTouched = touched;
	}

	public bool getBoatAlreadyTouched () {
		return boatAlreadyTouched;
	}


}