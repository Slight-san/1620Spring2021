using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManger;

    public int difficulty;
   
    void Start()
    {
        button = GetComponent<Button>();
        gameManger = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
        button.onClick.AddListener(SetDifficulty);
    }

    
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was ckicked");
        gameManger.StartGame(difficulty);
        
    }
}
