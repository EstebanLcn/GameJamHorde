using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float PLAYER_LEVEL_SPAWN_DISTANCE;
    public int START_LOADING_LEVEL_AMOUNT;

    public GameObject[] tiles;
    public GameObject player;

    private Vector3 lastEndPoint;

    private void Start()
    {
        lastEndPoint = GameObject.Find("EndPoint").transform.position;

        for(int i=0; i<START_LOADING_LEVEL_AMOUNT; i++)
        {
            SpawnLevelPart();
        }
    }
    
    private void FixedUpdate()
    {
        if(Vector3.Distance(player.transform.position, lastEndPoint) < PLAYER_LEVEL_SPAWN_DISTANCE)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform levelPartTransform = Instantiate(tiles[Random.Range(0, tiles.Length)].transform, lastEndPoint, Quaternion.identity);
        lastEndPoint = levelPartTransform.Find("EndPoint").position;
    }
}
