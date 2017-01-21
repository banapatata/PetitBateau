using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatBehaviour : MonoBehaviour {

	Rigidbody2D rb;
	Transform child;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		child = transform.Find ("Sprite").transform;
	}

	void Update () {
		if (Input.GetKeyDown ("escape")) {
			rb.position = Vector2.zero;
		}
		child.transform.up = Vector2.Lerp(child.transform.up, rb.velocity, 0.75f * Time.deltaTime);
	}

	public void HitByWave (Vector2 wave) {
		rb.AddForce (wave * 2f, ForceMode2D.Impulse);
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("Wave")) {
			if (!other.GetComponent <waveBehavior> ().getBoatAlreadyTouched ()) {
				other.GetComponent <waveBehavior> ().setBoatAlreadyTouched (true);
				HitByWave (other.GetComponent <waveBehavior> ().getDirection ());
			}
		}
	}
}
