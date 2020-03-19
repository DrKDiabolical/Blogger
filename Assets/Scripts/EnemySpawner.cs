using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab; // Contains prefab for enemy
    [SerializeField] bool moveRight = true; // Defines direction for spawned enemies
    [SerializeField] float startDelay = 1f; // Defines the start delay
    [SerializeField] float spawnRate = 5f; // Defines the spawn rate

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnRate); // Spawns an enemy after a defined delay and at the defined rate
    }

    // Spawns an enemy
    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity); // Instantiates enemy
        enemy.transform.parent = gameObject.transform; // Sets enemy as child of spawner
        enemy.GetComponent<Enemy>().moveRight = moveRight; // Defines which direction that the enemy moves
    }
}
