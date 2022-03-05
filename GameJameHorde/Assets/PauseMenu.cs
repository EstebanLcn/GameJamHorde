using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private string sceneName;
    bool isPaused = false;

    public GameObject pauseMenu;
    public GameObject inGameUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        inGameUI.SetActive(true);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        pauseMenu.SetActive(false);

        sceneName = "MainMenu";
        SceneManager.LoadScene(sceneName);
    }
}
