using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : MonoBehaviour
{
    public MainScript mainScript;
    public GameObject RiverGameObject;
    
    // Update is called once per frame
    void Update()
    {
        float temp = mainScript.temperature;
        float riverHeight = (temp - mainScript.tempMin) * (500) / (mainScript.tempMin - mainScript.tempMax);
        Vector3 newPos = RiverGameObject.transform.position;
        newPos.y = riverHeight;
        RiverGameObject.transform.position = newPos;
    }
}
