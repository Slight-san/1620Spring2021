﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
   
    public Int numberCount;
    public Text counterText;
        
   
    void Update()
    {
		numberCount++;
		counterText.text = numberCount.ToString();
        
    }
}
