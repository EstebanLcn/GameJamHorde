using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
  private Player _player;
  public Animator transition;

  public float _transitionTime = 1f;
  // Start is called before the first frame update
  void Start()
  {
    _player = gameObject.GetComponent<Player>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void LoadHellLevel()
  {
    StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
  }

  IEnumerator LoadLevel(int indexLevel)
  {
    transition.SetTrigger("TriggerAnimation");

    yield return new WaitForSeconds(_transitionTime);

    SceneManager.LoadScene(indexLevel);
  }
}
