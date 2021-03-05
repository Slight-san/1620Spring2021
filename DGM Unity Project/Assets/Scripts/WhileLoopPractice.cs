using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopPractice : MonoBehaviour
{
    private int x = 0;
    void Start()
    {
        while (x < 10)
        {
            Console.WriteLine(x);
            x++;
        }
    }
    
}
