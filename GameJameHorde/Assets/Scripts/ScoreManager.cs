using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int currentScore;
    int minScore = 0;
    public Text scoreText;
    public StaminaBar StaminaBar;
    string scoreString;


    // Start is called before the first frame update
    void Start()
    {
        int currentScore = 0;
    }

        public void AddPoints(int points)
    {
        currentScore += points;
        scoreString = currentScore.ToString();
        scoreText.text = scoreString;

        StaminaBar.AddStamina();
    }

}
