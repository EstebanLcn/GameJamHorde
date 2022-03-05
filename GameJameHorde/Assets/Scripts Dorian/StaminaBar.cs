using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;
    int maxStamina = 10;

    private void Start()
    {
        slider.maxValue = maxStamina;
        slider.value = 0;
    }

    private void Update()
    {//////////////////////////////////////////////////////   POUR TESTER  ////////////////////////////////////////////////////////////
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AddStamina();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ResetStamina();
        }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }

    public void AddStamina()
    {
        slider.value += 1;
    }

    public void ResetStamina()
    {
        slider.value = 0;
    }
}
