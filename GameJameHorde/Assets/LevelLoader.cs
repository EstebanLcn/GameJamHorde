using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator _transition;
    public float _transitionTime = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex == 1 ? SceneManager.GetActiveScene().buildIndex + 1 : SceneManager.GetActiveScene().buildIndex - 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        _transition.SetTrigger("start");

        yield return new WaitForSeconds(_transitionTime);

        SceneManager.LoadScene(levelIndex);
    }


}