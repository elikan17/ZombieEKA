using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject collectible;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnCollectible", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCollectible()
    {
        Vector3 spawnPos = new(Random.Range(-8, 8), 0.5f, Random.Range(0, 10));
        Instantiate(collectible, spawnPos, Quaternion.identity);

    }

}
