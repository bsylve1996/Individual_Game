using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    // Start is called before the first frame update

    public GameObject FollowTarget;
    private Vector3 targetPos;

    public float moveSpeed;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        targetPos = new Vector3(FollowTarget.transform.position.x,FollowTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}
