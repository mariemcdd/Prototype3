using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;

    private float _startDelay = 2f;
    private float _repeatRate = 2f;
    private Vector3 _spawnPosition = new Vector3(30, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
    }

    private void SpawnObstacle()
    {
        Instantiate(ObstaclePrefab, _spawnPosition, ObstaclePrefab.transform.rotation);
    }
}
