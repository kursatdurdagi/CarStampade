using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public GameObject PlayerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    float barPos;

    // Use this for initialization
    void Start () {
        _cameraOffset = transform.position - PlayerTransform.transform.position;	
	}
    private void Update()
    {
        PlayerTransform = GameObject.FindWithTag("Player");
        barPos = GameObject.FindWithTag("Player").transform.position.z;
    }


    void FixedUpdate()
    {
        Vector3 tmpPosition = transform.position;
        tmpPosition.z = barPos;
        transform.position = tmpPosition;
    }
    //   void FixedUpdate () {

    //       Vector3 newPos = PlayerTransform.transform.position + _cameraOffset;

    //       transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

    //       if (LookAtPlayer)
    //           transform.LookAt(PlayerTransform.transform);

    //}
}
