using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet_Hell_Movement : MonoBehaviour
{
    [SerializeField]private float playerSpeed = 12f;
    private float mouseXSpeed = 2f;
    private float mouseYSpeed = 2f;
    private float timeLeft = 60f;
    private int timesHit= 0;
    private Vector3 MousePositionViewport = Vector3.zero;
    private Quaternion DesiredRotation = new Quaternion();
    [SerializeField]private ParticleSystem hitEffect;
    [SerializeField]private Transform startPosition;
    [SerializeField]private int hitsMax;
    private float RotationSpeed = 15;
    [SerializeField]private Text hitText;
    [SerializeField]private Text timeRemaining;

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0){
        timeLeft -= Time.deltaTime;
        }

        if(timeLeft <= 0){
            SceneManager.LoadScene("BulletHellLoseScene");
        }

        if(timesHit >= hitsMax){
            SceneManager.LoadScene("BulletHellWin");
        }
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);

        float angle = AngleBetweenTwoPoints(transform.position, mouseWorldPosition);

        transform.rotation = Quaternion.Euler (new Vector3(0f, 0f, angle + 180f));
        
        float horizontal = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * horizontal * playerSpeed *Time.deltaTime);
        timeRemaining.text = "Time Left: " + timeLeft;

        ShowTime(timeLeft);
    }

    float AngleBetweenTwoPoints(Vector2 a, Vector2 b){
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    void ShowTime(float timeToDisplay){
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeRemaining.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Platform"){
            transform.position = startPosition.position;
        } 
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Enemy")){
            Instantiate(hitEffect, this.transform.position, Quaternion.identity);
            timesHit++;
            hitText.text = "Times Hit: " + timesHit + "/" + hitsMax;
            Destroy(other.gameObject);
        }
    }
}
