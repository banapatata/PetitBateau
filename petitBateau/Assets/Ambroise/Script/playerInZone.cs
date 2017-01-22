using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInZone : MonoBehaviour
{

    private float now;
    [SerializeField]
    private float timerState = 5.0f;
    private int newState = 0;
    private bool isPlayerIn;
    private bool isCharge = false;

    // Use this for initialization
    void Start()
    {
        now = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<setGameOver>().getIsAlive())
        {
            if (isPlayerIn && now + timerState < Time.time && newState < 6)
            {
                newState += 1;
                transform.Find("Enemi").GetComponent<Charge>().setState(newState);
                now = Time.time;
				if (newState == 6) {
					isCharge = true;
				}
            }
            else if (!isPlayerIn && now + timerState < Time.time && newState > 0 && !isCharge)
            {
                newState -= 1;
                transform.Find("Enemi").GetComponent<Charge>().setState(newState);
                now = Time.time;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isPlayerIn = true;
            now = Time.time;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isPlayerIn = false;
            now = Time.time;
        }
    }
}
