using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float enemySpeed = 5f; 
    private float enemyLifeSpan = 10f;
    [SerializeField]private Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerPos.position.x + " " + playerPos.position.y + " " + playerPos.position.z); 
        playerPos = playerPos.gameObject.transform;
        
        float DistanceBtwPlayerAndEnemy = Vector3.Distance(playerPos.position, this.transform.position);
        

        if(DistanceBtwPlayerAndEnemy < 5f){
            transform.position = Vector3.MoveTowards(this.transform.position, playerPos.position, -enemySpeed * Time.deltaTime);
            enemySpeed = 10f;
        } else if(DistanceBtwPlayerAndEnemy <= 30f && DistanceBtwPlayerAndEnemy > 6f){
            transform.position = Vector3.MoveTowards(this.transform.position, playerPos.position, enemySpeed * Time.deltaTime); 
            enemySpeed = 9f;
        } else if(DistanceBtwPlayerAndEnemy >= 5f && DistanceBtwPlayerAndEnemy < 6f){
            
        }

        if(transform.position.x >= 37 || transform.position.y <= -15f || transform.position.x <= -35 || transform.position.y >= 22f){
            Destroy(gameObject);
        }

        enemyLifeSpan -= Time.deltaTime;

        if(enemyLifeSpan <= 0){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("Hit");
        }
    }
}
