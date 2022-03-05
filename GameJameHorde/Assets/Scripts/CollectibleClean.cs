using UnityEngine;

public class CollectibleClean : MonoBehaviour
{
    public ScoreManagerClean scoreManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);

        if (other.tag == "Player")
        {
            scoreManager.AddPoints(1);
            Destroy(gameObject);
        }
    }
}