using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
  private int _damage = 1;
  public float _speed;

  // Update is called once per frame
  void Update()
  {
    transform.Translate(Vector2.left * _speed * Time.deltaTime);
  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      collision.GetComponent<Player>()._health -= _damage;
      Debug.Log("Player life count: " + collision.GetComponent<Player>()._health);
    }
  }
}
