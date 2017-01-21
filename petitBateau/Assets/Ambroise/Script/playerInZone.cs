using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInZone : MonoBehaviour
{

    private float now;
    [SerializeField]
    private float timerState = 5.0f;
    private int newState = 0;
    private bool iPlayerIn;
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
            if (iPlayerIn && now + timerState < Time.time && newState < 5)
            {


                newState = newState + 1;

                transform.Find("Enemi").GetComponent<Charge>().setState(newState);

                now = Time.time;

                isCharge = true;

            }
            else if (!iPlayerIn && now + timerState < Time.time && newState > 0 && !isCharge)
            {
                newState = newState - 1;

                transform.Find("Enemi").GetComponent<Charge>().setState(newState);

                now = Time.time;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            iPlayerIn = true;
            now = Time.time;

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {


            iPlayerIn = false;
            now = Time.time;

        }
    }
}
