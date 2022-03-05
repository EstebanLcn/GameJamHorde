using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _spawner;
    private float _timeBetweenSpawn;
    public float _startTimeBetweenSpawn;

    // Update is called once per frame
    void Update()
    {
        if(_timeBetweenSpawn >= 0)
        {
            Instantiate(_spawner, transform.position,  Quaternion.identity);
        } else {
            _timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
