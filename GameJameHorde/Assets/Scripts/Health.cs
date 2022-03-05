using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    int currentHeartsNum;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite lostHeart;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHeartsNum = 3;
    }
    private void Update()//test
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentHeartsNum > 0)
        {
            LoseHeart();
        }

    }

    void LoseHeart()
    {
                hearts[0].sprite = lostHeart;
                //Scene switch;
     
    }
}
