using System;
using UnityEngine;

public class GateKeeperBehaviour : MonoBehaviour
{
    public BoolData keyObj; //create "BoolData"
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (keyObj.value) //value script needed
        {
            print(true);
        }
        else
        {
            print(false);
        }
    }
}
