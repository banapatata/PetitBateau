using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickController : MonoBehaviour {

	public GameObject wave;
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
			GameObject newWave = Instantiate (wave, new Vector3 (waveVector.x, waveVector.y, 0), transform.rotation);
			newWave.GetComponent <waveBehavior> ().initMove (waveVector);
		}
	}
}
