using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsPractice : MonoBehaviour
{
    private string[] days = {"Monday", "Tuesday", "Wednesday","Thursday"};
    for (int i = 0; i < days.Length; i++)
    {
        Console.WriteLine(days[i]);
    }    
}