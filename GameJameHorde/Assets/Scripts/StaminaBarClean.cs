using UnityEngine;
using UnityEngine.UI;

public class StaminaBarClean : MonoBehaviour
{
    public Slider slider;
    int maxStamina = 5;

    private void Start()
    {
        slider.maxValue = maxStamina;
        slider.value = 0;
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
