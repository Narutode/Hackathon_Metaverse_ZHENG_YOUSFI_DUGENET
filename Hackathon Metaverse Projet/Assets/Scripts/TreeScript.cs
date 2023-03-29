using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public bool noLeaves = false;
    public bool dying = false;

    public List<GameObject> trees = new List<GameObject>();
    public List<GameObject> deadTrees = new List<GameObject>();

    public GameObject prefabDeadTree;

    public MainScript mainScript;

    private int timer = 50;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var tree in trees)
        {
            var pos = tree.transform.position;
            pos.y = -7.5f;
            tree.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 0)
        {
            if(mainScript.temperature >40)timer = 50;
            if(mainScript.temperature >42)timer = 25;
            if(mainScript.temperature >44)timer = 10;
            if (!noLeaves)
            {
                if (mainScript.temperature > 40f)
                    noLeaves = true;
            }
            else if (!dying)
            {
                if (mainScript.temperature > 42.5f)
                {
                    dying = true;
                }
            }
            if (noLeaves)
            {
                if (trees.Any())
                {
                    int randI = Random.Range(0, trees.Count());
                    GameObject rTree = trees[randI];
                    var trans = rTree.transform;
                    var newpos = trans.position;
                    newpos.y = 7;
                    trans.position = newpos;
                    GameObject newDead = Instantiate(prefabDeadTree, trans.position, prefabDeadTree.transform.rotation, transform);
                    deadTrees.Add(newDead);
                    trees.Remove(rTree);
                    Destroy(rTree);
                }
            }
            if (dying)
            {
                if (deadTrees.Any())
                {
                    if (Random.Range(0, 1) > 0.5)
                    {
                        int randI = Random.Range(0, deadTrees.Count());
                        GameObject rTree = deadTrees[randI];
                        deadTrees.Remove(rTree);
                        Destroy(rTree);
                    }

                }
            }
        }
        else
        {
            timer--;
        }
    }
}
