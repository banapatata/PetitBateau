using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveBarBehavior : MonoBehaviour
{

    [SerializeField]
    private float MaxEnergie;
    public Slider Bar;
    private float pourcentage;
    public Image Fill;
    [SerializeField]
    private float loadSpeed = 0.005f;
    [SerializeField]
    float minForce = 5.0f;

    // Use this for initialization
    void Start()
    {
        pourcentage = 1 / MaxEnergie;
        Bar.maxValue = 1;
        Bar.minValue = 0.00f;

    }

    // Update is called once per frame
    void Update()
    {
        Bar.value += loadSpeed;
        if (Bar.value< minForce*pourcentage)
        {
            Fill.color = Color.red;
        }
        else
        {
            Fill.color = Color.cyan;
        }
        Bar.value += loadSpeed;
    }

    public float UpdateWaveBar(float puissancevague)
    {
        if (pourcentage * puissancevague < Bar.value)
        {
            Bar.value -= pourcentage * puissancevague;
            return puissancevague;
        }
        else
        {
            puissancevague = Bar.value / pourcentage;
            Bar.value -= pourcentage * puissancevague;
            return puissancevague;
        }
    }

    public bool IsPowerInBar()
    {
            if (minForce* pourcentage < Bar.value)
            {
                return true;
            }
            else return false;
       
    }
}
