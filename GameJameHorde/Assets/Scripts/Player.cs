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
    public StaminaBarClean staminaBar;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite oldSprite;
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

        if(staminaBar.slider.value == 5)
        {
            spriteRenderer.sprite = newSprite;
        }
        else
        {
            spriteRenderer.sprite = oldSprite;
        }
  }

  void FixedUpdate()
  {
    _playerSpeed += 0.001f;
    _rb.velocity = new Vector2(_playerSpeed, _playerDirection.y * _playerSpeed);
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Obstacle")
    {
      _health -= 1;
    }
    if (collision.gameObject.tag == "Ennemy")
    {
      _health -= 1;
    }
  }

  private void OnTriggerEnter(Collider collectible)
  {
    Destroy(gameObject);
  }
}