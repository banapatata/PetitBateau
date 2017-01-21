using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveBarBehavior : MonoBehaviour
{

    [SerializeField]
    private float MaxEnergie;
    public Slider healthBarSlider;
    private float pourcentage;
    [SerializeField]
    private float loadSpeed = 0.005f;

    // Use this for initialization
    void Start()
    {
        pourcentage = 1 / MaxEnergie;
        healthBarSlider.maxValue = 1;
        healthBarSlider.minValue = 0.00f;

    }

    // Update is called once per frame
    void Update()
    {
        healthBarSlider.value += loadSpeed;
    }

    public float UpdateWaveBar(float puissancevague)
    {
        if (pourcentage * puissancevague < healthBarSlider.value)
        {
            healthBarSlider.value -= pourcentage * puissancevague;
            return puissancevague;
        }
        else
        {
            puissancevague = healthBarSlider.value / pourcentage;
            healthBarSlider.value -= pourcentage * puissancevague;
            Debug.Log(puissancevague);

            return puissancevague;
        }
    }
}
