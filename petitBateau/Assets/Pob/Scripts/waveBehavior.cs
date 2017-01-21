using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveBehavior : MonoBehaviour {

	Rigidbody2D rb;

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
		initMove (Vector2.right * 4);
	}

	public void initMove (Vector2 vector) {
		if (vector.magnitude < 1f) {
			vector = vector.normalized;
		} else if (vector.magnitude > 10f) {
			vector = vector.normalized;
			vector *= 5f;
		}
		transform.up = vector;
		rb.AddForce (vector, ForceMode2D.Impulse);
	}
}
