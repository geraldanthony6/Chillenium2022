using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]private GameObject[] enemies;
    private float timeByWaves = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(10);
    }

    // Update is called once per frame
    void Update()
    {
        if(timeByWaves <= 0){
            timeByWaves = 5f;
            SpawnEnemies(Random.Range(15, 20));
        } else if(timeByWaves <= 5 && timeByWaves > 0){
            timeByWaves -= Time.deltaTime;
        }
    }

    void SpawnEnemies(int numberOfEnemies){
        for(int i = 0; i < numberOfEnemies; i++){
            Instantiate(enemies[Random.Range(0, 2)], new Vector3(Random.Range(-30f, 30f), Random.Range(-25f, 25f), 0), Quaternion.identity);
        }
    }
}
