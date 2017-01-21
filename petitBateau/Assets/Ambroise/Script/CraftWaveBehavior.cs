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

    [SerializeField]
    private Sprite sprite1;

    [SerializeField]
    private Sprite sprite2;

    [SerializeField]
    private bool faischier = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HitByWave(Vector2 wave)
    {
        faischier = true;
        GetComponent<Rigidbody2D>().AddForce(wave * 2.0f, ForceMode2D.Impulse);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        this.GetComponent<Collider2D>().isTrigger = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wave")
        {
            Debug.Log("test");

            if (other.gameObject.GetComponent<waveBehavior>().getDirection().magnitude < 6.0f)
            {
                if (!other.gameObject.GetComponent<waveBehavior>().getBoatAlreadyTouched())
                {
                    other.gameObject.GetComponent<waveBehavior>().setBoatAlreadyTouched(true);
                    HitByWave(other.gameObject.GetComponent<waveBehavior>().getDirection());
                }
            }
            else
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
                Actualscrap.GetComponent<SpriteRenderer>().sprite = sprite1;
                random1 = Random.Range(-1.0f, 1.0f);
                random2 = Random.Range(-1.0f, 1.0f);
                Actualscrap = Instantiate(scrap, transform.position + new Vector3(0.02f, -0.02f), Quaternion.identity);
                Actualscrap.GetComponent<Rigidbody2D>().AddForce(new Vector2(random1, random2) * speed);
                Actualscrap.GetComponent<SpriteRenderer>().sprite = sprite2;

                Destroy(this.gameObject);
            }
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<setGameOver>().GameOver();
        }

        if (other.gameObject.name == "ColliderLeft" || (other.gameObject.name == "ColliderRight" && faischier))
        {
            Destroy(this.gameObject);
        }
    }
}
