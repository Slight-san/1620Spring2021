using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int coinValue = 5;
    public int numberCount;
    public Text counterText;

    void OnTriggerEnter2D()
    {
        numberCount += coinValue;
        counterText.text = numberCount.ToString();
        gameObject.SetActive(false);
    }
}
