using UnityEngine;

public class FishSpawner : MonoBehaviour
{

    public GameObject enemy;
    public float spawnTime = 2f;
    public float range;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("EnemySpawner", 1f, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void EnemySpawner()
    {
        float x = Random.Range(-range, range);
        Vector3 spawnPosition = new Vector3(x, 6f, 0);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}
