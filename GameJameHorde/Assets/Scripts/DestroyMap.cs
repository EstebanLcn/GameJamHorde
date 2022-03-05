using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMap : MonoBehaviour
{

  private float _destroyTime = 20;

  void FixedUpdate()
  {
    Destroy(gameObject, _destroyTime);
  }
}
