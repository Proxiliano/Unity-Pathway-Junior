using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    public float difficulty;
    // Check which button is clicked and set difficulty accordingly
    public bool easyButtonClicked()
    {
        return button.gameObject.name == "Easy Button";
    }
    public bool mediumButtonClicked()
    {
        return button.gameObject.name == "Medium Button";
    }
    public bool hardButtonClicked()
    {
        return button.gameObject.name == "Hard Button";
    }
    

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        if (easyButtonClicked())
        {
             difficulty = 0.5f;
        }
        else if (mediumButtonClicked())
        {
            difficulty = 0.75f;
        }
        else if (hardButtonClicked())
        {
            difficulty = 1f;
        } 
        gameManagerX.spawnRate /= difficulty;
        gameManagerX.StartGame();
    }



}
