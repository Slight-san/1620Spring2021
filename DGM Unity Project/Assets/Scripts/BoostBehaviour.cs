using UnityEngine;

public class BoostBehaviour : MonoBehaviour
{
    public bool hasKey;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (hasKey)
        {
            print(message:"Boost");
        }
    }
}
