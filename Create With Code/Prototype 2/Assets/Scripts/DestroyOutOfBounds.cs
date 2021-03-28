using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35;
    private float botBound = -12;
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < botBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
