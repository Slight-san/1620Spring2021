using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject Ball;
    
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(Ball);
        }
    }
}