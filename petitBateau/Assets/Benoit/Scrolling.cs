using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

	[SerializeField]
	private Vector2 speed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = speed;
	}
	
	// Update is called once per frame
	void Update () {
		//if (isAlive) {
			
		//}
	}
}
