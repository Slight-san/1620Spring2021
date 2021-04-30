using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
    private Button button;
   
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was ckicked");
    }
}
