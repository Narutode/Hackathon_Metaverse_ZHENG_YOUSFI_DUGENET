using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public TextMeshProUGUI TextTemperature;
    public float temperature;
    private Color32 redColor = new Color32(255, 0, 0, 255); // couleur rouge
    Color32 orangeColor = new Color32(255, 165, 0, 255);
    // Start is called before the first frame update
    void Start()
    {
        temperature = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if (temperature > 40)
        {
            TextTemperature.color = orangeColor; // changer la couleur du texte à orange
        }
        if (temperature > 60)
        {
            TextTemperature.color = redColor; // changer la couleur du texte à rouge
        }
    }

    private void FixedUpdate()
    {
        temperature+=.1f;
        TextTemperature.text = temperature.ToString(); 
    }
}
