using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Public variables
    public GameObject[] animalPrefab;
    public float spawnPosX = 15;

    // Private variables
    private float spawnPosZ = 20;
    private float spawnTime = 2.0f;
    private float spawnRate = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // At the start of the game, this method will periodically call another method
        InvokeRepeating(nameof(SpawnRandomAnimals), spawnTime, spawnRate);
    }

    // Spawns animals at random
    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
        Instantiate(animalPrefab[animalIndex], spawnPos,
            animalPrefab[animalIndex].transform.rotation);
    }
}
