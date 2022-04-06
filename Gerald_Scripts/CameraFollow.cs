using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followPlayer;
    public Transform cameraTransform;
    public Vector3 playerOffset;
    public float MoveSpeed = 400f;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = transform;
    }

    public void SetTarget(Transform newTransformTarget){
        followPlayer = newTransformTarget;
    }

    private void LateUpdate(){
        if(followPlayer != null){
            cameraTransform.position = Vector3.Lerp(cameraTransform.position, followPlayer.position + playerOffset, MoveSpeed * Time.deltaTime);
        }
    }
}
