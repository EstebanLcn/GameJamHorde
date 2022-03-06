using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
    public Slider slider;
    int maxStamina = 10;

    private void Start()
    {
        slider.maxValue = maxStamina;
        slider.value = 0;
    }

    private void Update()
    {
        slider.value += 1 * Time.deltaTime;
    }
}
