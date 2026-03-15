
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRangeX = 9;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float spawnPosZ = Random.Range(-spawnRangeX, spawnRangeX); 
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX); 
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ); // Create a spawn position with random X and Z coordinates
        Instantiate(enemyPrefab, GenerateSpawnPosition());
    }
        private Vector3 GenerateSpawnPosition()
    {
        float spawnPosZ = Random.Range(-spawnRangeX, spawnRangeX); 
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX); 
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ); // Create a random
        return randomPos; // Return the random spawn position
    }
    
}

