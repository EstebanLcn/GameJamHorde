using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScore : MonoBehaviour
{
    public ScoreManagerClean scoreManager;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreManager.scoreString;
    }
}
