using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private bool noLeaves = false;
    private bool dying = false;

    private List<GameObject> trees = new List<GameObject>();
    private List<GameObject> deadTrees = new List<GameObject>();

    private GameObject prefabDeadTree;

    public MainScript mainScript;

    // Start is called before the first frame update
    void Start()
    {
        trees = GetComponentsInChildren<GameObject>().ToList();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!noLeaves)
        {
            if (mainScript.temperature > 42)
                noLeaves = true;
        }
        else if (!dying)
        {
            if (mainScript.temperature > 42)
            {
                dying = true;
            }
        }

        if (dying)
        {
            
        }
        else if (noLeaves)
        {
            
        }
        /*
        float temp = mainScript.temperature;
        float riverHeight = (temp - 15) * (500) / (15 - 40);
        Vector3 newPos = RiverGameObject.transform.position;
        newPos.y = riverHeight;
        RiverGameObject.transform.position = newPos;*/
    }
}
