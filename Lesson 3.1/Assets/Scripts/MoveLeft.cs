using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController _playerControllerScript;
    private float leftBound = -15;
   
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (_playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * speed));
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
