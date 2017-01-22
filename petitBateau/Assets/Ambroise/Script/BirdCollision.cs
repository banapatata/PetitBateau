using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    private bool isPlayerKill = false;

    [SerializeField]
    private float movementSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerKill)
        {   
            transform.position = transform.position +Vector3.up * Time.deltaTime * movementSpeed;
            transform.localEulerAngles = (new Vector3(0,0,0.0f));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            isPlayerKill=true;
        }
    }
}
