using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController _playerControllerScript;
    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        _playerControllerScript = gameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (_playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
