using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<setGameOver>().getIsAlive())
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }

        if (transform.position.x < -47.5)
        {
            GameObject.Destroy(this.gameObject );
        }
    }
}
