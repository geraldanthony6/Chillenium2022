using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [SerializeField]private GameObject[] maps;
    //private int RandomNum = Random.Range(0,1);
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(maps[Random.Range(0,1)], maps[Random.Range(0,1)].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
