using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boid : MonoBehaviour
{
    public Vector3 velocity;
    public float maxVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        velocity = this.transform.forward * maxVelocity; // Initial speed
    }

    // Update is called once per frame
    void Update()
    {
        // Limit speed
        if (velocity.magnitude > maxVelocity)
        {
            velocity = velocity.normalized * maxVelocity;
        }
        
        this.transform.position += velocity * Time.deltaTime;
        this.transform.rotation = Quaternion.LookRotation(velocity);

        if (Random.value < 0.001)
        {
            Destroy(this.gameObject);
        }
        
    }
}
