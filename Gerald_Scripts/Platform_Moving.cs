using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Moving : MonoBehaviour
{
    [SerializeField]private float platformMovementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * platformMovementSpeed * Time.deltaTime);
    }
}
