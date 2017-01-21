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
			Debug.Log (startPos);
			Debug.Log (waveVector);
			GameObject newWave = Instantiate (wave, new Vector3 (startPos.x, startPos.y, 0), transform.rotation);
			Debug.Break ();
			newWave.GetComponent <waveBehavior> ().initMove (waveVector);
		}
	}
}
