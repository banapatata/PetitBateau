using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatBehaviour : MonoBehaviour
{

    Rigidbody2D rb;
    Transform child;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //child = transform.Find ("Sprite").transform;
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            rb.position = Vector2.down * 4;
        }
       
            transform.up = Vector2.Lerp(transform.up, rb.velocity, 0.75f * Time.deltaTime);

    }

    public void hitByWave(Vector2 wave)
    {

        rb.AddForce(wave * 2, ForceMode2D.Impulse);
    }
}
