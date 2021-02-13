using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int x = 100 + 50;
    public static int sum1 = 80 + 80; 
    
    public static int sum2 = sum1 + 150;
    
    public static int sum3 = sum2 * sum1;

    // errors in unity for invalid use of "{"?
    {
        int y = sum3;
        Console.WriteLine(y);
    }
    
}
// error: "{", "(", Tuple?, ";"