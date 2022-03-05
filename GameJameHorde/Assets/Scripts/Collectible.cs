using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ScoreManager scoreManager;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Debug.Log(other.tag);
            scoreManager.AddPoints(1);
            Destroy(gameObject);
        }
    }
}
