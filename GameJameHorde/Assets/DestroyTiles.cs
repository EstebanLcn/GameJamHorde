using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTiles : MonoBehaviour
{
    private float _destroyTime = 35;
    void FixedUpdate()
    {
        Destroy(gameObject, _destroyTime);
    }
}
