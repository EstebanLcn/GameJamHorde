using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleClean : MonoBehaviour
{
    public ScoreManagerClean scoreManager;
    Scene m_scene;
    string sceneName;

    private void Update()//test
    {
        m_scene = SceneManager.GetActiveScene();
        sceneName = m_scene.name;
        if (sceneName == "DeathWorld")
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            scoreManager.AddPoints(1);
            Destroy(gameObject);
        }
    }
}