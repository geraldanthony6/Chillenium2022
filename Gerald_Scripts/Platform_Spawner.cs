using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Spawner : MonoBehaviour
{
    [SerializeField]private Transform[] platformSpawnPoints;
    [SerializeField]private Transform[] goldSpawnPoints;
    [SerializeField]private GameObject[] platform;
    [SerializeField]private GameObject gold;
    private float spawnTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlatforms(3);
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTime <= 0){
            spawnTime = 2f;
            SpawnPlatforms(Random.Range(1, 6));
        } else if(spawnTime <= 2 && spawnTime > 0){
            spawnTime -= Time.deltaTime;
        }
    }

    void SpawnPlatforms(int numberToSpawn){
        for(int i = 0; i < numberToSpawn; i++){
            Instantiate(platform[Random.Range(0, 2)], new Vector3(Random.Range(0f, 30f), Random.Range(-18f, 6f), 0), Quaternion.identity);
            Instantiate(gold, goldSpawnPoints[Random.Range(0, 2)].position, Quaternion.identity);
        }
    }
}
