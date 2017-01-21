using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftWaveBehavior : MonoBehaviour
{

    [SerializeField]
    private GameObject scrap;

    private GameObject Actualscrap;

    [SerializeField]
    private float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wave")
        {

            GetComponent<SpriteRenderer>().enabled = false;
            float random1 = Random.Range(-1.0f, 1.0f);
            float random2 = Random.Range(-1.0f, 1.0f);
            Actualscrap = Instantiate(scrap, transform.position + new Vector3(0.02f, 0.02f), Quaternion.identity);
            Actualscrap.GetComponent<Rigidbody2D>().AddForce(new Vector2(random1, random2) * speed);
            random1 = Random.Range(-1.0f, 1.0f);
            random2 = Random.Range(-1.0f, 1.0f);
            Actualscrap = Instantiate(scrap, transform.position + new Vector3(-0.02f, 0.02f), Quaternion.identity);
            Actualscrap.GetComponent<Rigidbody2D>().AddForce(new Vector2(random1, random2) * speed);
            random1 = Random.Range(-1.0f, 1.0f);
            random2 = Random.Range(-1.0f, 1.0f   );
            Actualscrap = Instantiate(scrap, transform.position + new Vector3(0.02f, -  0.02f), Quaternion.identity);
            Actualscrap.GetComponent<Rigidbody2D>().AddForce(new Vector2(random1, random2) * speed);
            Destroy(this.gameObject);
        }
    }
}
