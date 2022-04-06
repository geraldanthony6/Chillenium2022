using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Hell_Shooting : MonoBehaviour
{
    [SerializeField]private Transform firePoint;
    [SerializeField]private Transform firePoint2;
    [SerializeField]private Transform firePoint3;
    [SerializeField]private Transform firePoint4;
    [SerializeField]private Transform firePoint5;
    [SerializeField]private Transform firePoint6;
    [SerializeField]private Transform firePoint7;
    [SerializeField]private Transform firePoint8;
    [SerializeField]private GameObject bullet;
    [SerializeField]private float bulletForce = 50f;
    private float bulletCooldown = 0;
    private float gunTypePlatform = 0;
    private int RandomShootAbility = 1;
    private int OnePeatAttack = 0;
    private int ThreePeatAttack = 0;

    private int UltimateAttack = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RandomShootAbility == 0){        
        
            if(bulletCooldown > 0){
            bulletCooldown -= Time.deltaTime;
        }
        if(bulletCooldown <= 0){
        GameObject tmpBullet = Instantiate(bullet, firePoint.transform.position, Quaternion.identity);
        Rigidbody tmpRb = tmpBullet.GetComponent<Rigidbody>();

        tmpRb.velocity = firePoint.right * bulletForce;

        OnePeatAttack++;
        bulletCooldown = 2f;
        }
        
        if(OnePeatAttack >= 3){
            RandomShootAbility = 2;
            OnePeatAttack = 0;
        }
    }

        if(RandomShootAbility == 1){        
        
            if(bulletCooldown > 0){
            bulletCooldown -= Time.deltaTime;
        }
        if(bulletCooldown <= 0){
    
        GameObject tmpBullet = Instantiate(bullet, firePoint.transform.position, Quaternion.identity);
        GameObject tmpBullet2 = Instantiate(bullet, firePoint2.transform.position, Quaternion.identity);
        GameObject tmpBullet3 = Instantiate(bullet, firePoint3.transform.position, Quaternion.identity);

        Rigidbody tmpRb = tmpBullet.GetComponent<Rigidbody>();
        Rigidbody tmpRb2 = tmpBullet2.GetComponent<Rigidbody>();
        Rigidbody tmpRb3 = tmpBullet3.GetComponent<Rigidbody>();


        tmpRb.velocity = firePoint.right * bulletForce;
        tmpRb2.velocity = firePoint2.right * bulletForce;
        tmpRb3.velocity = firePoint3.right * bulletForce;
        

        ThreePeatAttack++;
        bulletCooldown = 2f;
        }
        
        if(ThreePeatAttack >= 5){
            RandomShootAbility = 0;
            ThreePeatAttack = 0;
        }
    }

        if(RandomShootAbility == 2){        
        
            if(bulletCooldown > 0){
            bulletCooldown -= Time.deltaTime;
        }
        if(bulletCooldown <= 0){
        GameObject tmpBullet = Instantiate(bullet, firePoint.transform.position, Quaternion.identity);
        GameObject tmpBullet2 = Instantiate(bullet, firePoint2.transform.position, Quaternion.identity);
        GameObject tmpBullet3 = Instantiate(bullet, firePoint3.transform.position, Quaternion.identity);
        GameObject tmpBullet4 = Instantiate(bullet, firePoint4.transform.position, Quaternion.identity);
        GameObject tmpBullet5 = Instantiate(bullet, firePoint5.transform.position, Quaternion.identity);
        GameObject tmpBullet6 = Instantiate(bullet, firePoint6.transform.position, Quaternion.identity);
        GameObject tmpBullet7 = Instantiate(bullet, firePoint7.transform.position, Quaternion.identity);
        GameObject tmpBullet8 = Instantiate(bullet, firePoint8.transform.position, Quaternion.identity);
        

        Rigidbody tmpRb = tmpBullet.GetComponent<Rigidbody>();
        Rigidbody tmpRb2 = tmpBullet2.GetComponent<Rigidbody>();
        Rigidbody tmpRb3 = tmpBullet3.GetComponent<Rigidbody>();
        Rigidbody tmpRb4 = tmpBullet4.GetComponent<Rigidbody>();
        Rigidbody tmpRb5 = tmpBullet5.GetComponent<Rigidbody>();
        Rigidbody tmpRb6 = tmpBullet6.GetComponent<Rigidbody>();
        Rigidbody tmpRb7 = tmpBullet7.GetComponent<Rigidbody>();
        Rigidbody tmpRb8 = tmpBullet8.GetComponent<Rigidbody>();



        tmpRb.velocity = firePoint.right * bulletForce;
        tmpRb2.velocity = firePoint2.right * bulletForce;
        tmpRb3.velocity = firePoint3.right * bulletForce;
        tmpRb4.velocity = firePoint4.right * bulletForce;
        tmpRb5.velocity = firePoint5.right * bulletForce;
        tmpRb6.velocity = firePoint6.right * bulletForce;
        tmpRb7.velocity = firePoint7.right * bulletForce;
        tmpRb8.velocity = firePoint8.right * bulletForce;


        UltimateAttack++;
        //Debug.Log(ThreePeatAttack);
        bulletCooldown = 1f;
        }
        
        if(UltimateAttack >= 6){
            RandomShootAbility = Random.Range(0, 2);
            UltimateAttack = 0;
        }
    }
        
    }
}
