using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public TextMeshProUGUI TextTemperature;
    public TextMeshProUGUI TextAnnée;
    public float temperature;
    public int année;
    private Color32 redColor = new Color32(255, 0, 0, 255); // couleur rouge
    Color32 orangeColor = new Color32(255, 165, 0, 255);

    public float tempMin = 38;
    public float tempMax = 60;
    // Start is called before the first frame update
    void Start()
    {
        temperature = tempMin;
        année = 2020;
    }

    // Update is called once per frame
    void Update()
    {
        if (temperature > 40)
        {
            TextTemperature.color = orangeColor; // changer la couleur du texte à orange
        }
        if (temperature > 45)
        {
            TextTemperature.color = redColor; // changer la couleur du texte à rouge
        }
    }

    private void FixedUpdate()
    {
        temperature+=.018f;
        année+=10;
        TextTemperature.text = "Temperature : " + temperature.ToString("0.000") + " °C";
        TextAnnée.text = "Année : " + année.ToString();
    }
}
