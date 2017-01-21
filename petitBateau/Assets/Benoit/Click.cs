using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	private Vector2 startPos;
	private Vector2 endPos;
	public Vector2 waveVector;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			startPos = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp (0)) {
			endPos = Input.mousePosition;
			waveVector = endPos - startPos;
		}
	}
}
