using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]private ParticleSystem enemyDeathParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 30f || transform.position.x < -30f || transform.position.y > 30f || transform.position.y < -30f){
            Destroy(gameObject);
        }  
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Enemy"){
            Instantiate(enemyDeathParticle, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(other.gameObject);
        } 
    }
}
