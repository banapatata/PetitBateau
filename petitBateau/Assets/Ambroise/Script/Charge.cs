﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    private Animator myAnimator;

    [SerializeField]
    private float movementSpeed;

    private int state;

    void Start()
    {
        myAnimator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<setGameOver>().getIsAlive())
        {
			myAnimator.SetInteger ("status", state);
                if (state == 6)
            	{
	                //transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
				Vector3 dir = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
				float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
				transform.position += -transform.up * Time.deltaTime * movementSpeed;
				Debug.Log ("charge en cours");
	            }
        }
    }

    public void setState(int newState)
    {
        state = newState;
    }
}
