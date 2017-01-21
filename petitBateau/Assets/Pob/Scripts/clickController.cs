using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickController : MonoBehaviour
{

    public GameObject wave;
    private Vector2 startPos;
    private Vector2 endPos;
    private Vector2 waveVector;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<setGameOver>().getIsAlive())
        {
            {
                if (Input.GetMouseButtonDown(0))
                {
                    startPos = cam.ScreenToWorldPoint(Input.mousePosition);
                }
                if (Input.GetMouseButtonUp(0))
                {
                    endPos = cam.ScreenToWorldPoint(Input.mousePosition);
                    waveVector = endPos - startPos;
                    GameObject newWave = Instantiate(wave, new Vector3(startPos.x, startPos.y, 0), transform.rotation) as GameObject;
                    newWave.name = "PlayerWave";
                    newWave.GetComponent<waveBehavior>().setDirection(waveVector);
                }
            }
        }
    }
}
