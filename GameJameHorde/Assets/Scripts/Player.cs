using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public int _health = 1;
  private int _scoreBoard = 0;

  public float _playerSpeed;
  private Rigidbody2D _rb;
  private Vector2 _playerDirection;

  // Start is called before the first frame update
  void Start()
  {
    _rb = GetComponent<Rigidbody2D>();
  }

  // Update is called once per framedd
  void Update()
  {
    float directionY = Input.GetAxisRaw("vertical");
    _playerDirection = new Vector2(0, directionY).normalized;
  }

  void FixedUpdate()
  {
    _playerSpeed += 0.001f;
    _rb.velocity = new Vector2(_playerSpeed, _playerDirection.y * _playerSpeed);
    Debug.Log(_rb);
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Obstacle")
    {
      _health -= 1;
      Debug.Log(_health);
    }
    if (collision.gameObject.tag == "Ennemy")
    {
      _health -= 1;
      Debug.Log(_health);
    }
  }

  private void OnTriggerEnter(Collider collectible)
  {
    Destroy(gameObject);
  }
}