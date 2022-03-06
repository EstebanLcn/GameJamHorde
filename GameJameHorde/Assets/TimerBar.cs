using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerBar : MonoBehaviour
{
    public Slider slider;
    int maxStamina = 10;
    Scene m_scene;
    string sceneName;


    private void Start()
    {
        slider.maxValue = maxStamina;
        slider.value = 0;
        m_scene = SceneManager.GetActiveScene();
        sceneName = m_scene.name;
    }

    private void Update()
    {
        slider.value += 1 * Time.deltaTime;

        if (slider.value == slider.maxValue)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
