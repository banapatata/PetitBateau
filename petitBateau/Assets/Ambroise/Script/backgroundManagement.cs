using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundManagement : MonoBehaviour {

    [SerializeField]
    private GameObject Background;
    private GameObject ActualBackground; 

    // Use this for initialization
    void Start () {
        ActualBackground = Instantiate(Background);
	}
	
	// Update is called once per frame
	void Update () {
		if (ActualBackground.transform.position.x < -20.0f)
        {
            ActualBackground =Instantiate(Background, new Vector3(47f, 0, 0), Quaternion.identity);
        }
	}
}
