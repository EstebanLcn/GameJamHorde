using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  public GameObject _spawner;
  private GameObject _objectToBeDestroyed;
  public float _spawnerSpeed = 0;
  private Vector2 _spawnerDirection;
  private Rigidbody2D _rb;

  private float _destroyTime = 5;
  private float _timeBetweenSpawn;
  public float _startTimeBetweenSpawn;


  // Start is called before the first frame update
  void Start()
  {
    _rb = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    float directionY = Input.GetAxisRaw("vertical");
    _spawnerDirection = new Vector2(0, directionY).normalized;

    if (_timeBetweenSpawn <= 0)
    {
      _objectToBeDestroyed = Instantiate(_spawner, new Vector2(transform.position.x, Random.Range(transform.position.y - 3, transform.position.y + 3)), Quaternion.identity);
      _timeBetweenSpawn = _startTimeBetweenSpawn;
    }
    else
    {
      _timeBetweenSpawn -= Time.deltaTime;
    }
    Destroy(_objectToBeDestroyed, _destroyTime);
  }

  void FixedUpdate()
  {
    _spawnerSpeed += 0.001f;
    _rb.velocity = new Vector2(_spawnerSpeed, 0);
  }
}
