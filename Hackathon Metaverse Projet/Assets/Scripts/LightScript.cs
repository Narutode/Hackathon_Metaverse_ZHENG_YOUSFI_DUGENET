using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LightScript : MonoBehaviour
{
    public MainScript mainScript;
    public Light directionalLight;
    public float intensity;
    public Color endColor = new Color(255, 165, 0);
    public float colorChangeDuration = 240f;

    public bool animted = false;
    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        float temp = mainScript.temperature;
        if(temp>40 && !animted)
        {
            animted = true;
            // Animation de la couleur de la lumière
            directionalLight.DOColor(endColor, colorChangeDuration);

            directionalLight.DOIntensity(intensity * 2f, colorChangeDuration);

        }
    }
}