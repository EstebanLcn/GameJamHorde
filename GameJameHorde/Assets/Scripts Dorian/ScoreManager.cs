using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int currentScore;
    int minScore = 0;
    public Text scoreText;
    string scoreString;


    // Start is called before the first frame update
    void Start()
    {
        int currentScore = 0;
    }

    private void Update()
    {//////////////////////////////////////////////////////   POUR TESTER  ////////////////////////////////////////////////////////////
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddPoints(5);
        }
     }
        ///

        void AddPoints(int points)
    {
        currentScore += points;
        scoreString = currentScore.ToString();
        scoreText.text = scoreString;
    }

}
