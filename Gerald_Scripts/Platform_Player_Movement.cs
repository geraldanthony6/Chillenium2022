using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Player_Movement : MonoBehaviour
{
    [SerializeField]private float speed = 3f; 
    [SerializeField]private int goldCount = 0;
    [SerializeField]private Rigidbody rb;
    
    [SerializeField]private bool canJump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * speed * horizontal * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && canJump == true){
            rb.AddForce(transform.up * 5f, ForceMode.Impulse);
            canJump = false;
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Gold"){
            goldCount++;
            Destroy(other.gameObject);
            Debug.Log(goldCount);
        }
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Platform")){
            canJump = true;
        }
    }
}
