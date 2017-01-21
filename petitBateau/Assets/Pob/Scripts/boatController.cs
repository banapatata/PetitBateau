using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatController : MonoBehaviour {

	boatBehaviour boatBehaviour;
	Vector2 inpulse;

	void Start () {
		boatBehaviour = GetComponent<boatBehaviour> ();
	}

	void Update () {
		inpulse = Vector2.zero;
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			inpulse += Vector2.left;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			inpulse += Vector2.right;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			inpulse += Vector2.up;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			inpulse += Vector2.down;
		}
		boatBehaviour.HitByWave (inpulse);
	}
}
