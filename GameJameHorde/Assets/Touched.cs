using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Touched : MonoBehaviour
{
    public string LevelName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        if (collider.gameObject.layer == LayerMask.NameToLayer("Wall") || collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
