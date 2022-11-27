using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] duckPrefabs;
    public float durationSpawn = 4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        durationSpawn -= Time.deltaTime;
        if (durationSpawn < 0)
        {
            durationSpawn = 5;
            int randEnemy = Random.Range(0, duckPrefabs.Length);
            int randSpawmPoint = Random.Range(0, spawnPoint.Length);
            Instantiate(duckPrefabs[randEnemy], spawnPoint[randSpawmPoint].position, transform.rotation);
            
        }
    }
}
