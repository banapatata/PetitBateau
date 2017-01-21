using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

	[SerializeField]
	private Vector2 speed = new Vector2(-3.0f,0.0f);

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = speed;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (!isAlive) {
			GetComponent<Rigidbody2D> ().velocity = 0;
		}*/
		if (transform.position.x + 12 < 0) {
			Destroy (gameObject);
		}
	}
}
