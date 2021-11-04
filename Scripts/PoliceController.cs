using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
    GameManager gm;

    public float Speed;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void FixedUpdate()
    {
        if(gm.isStart)
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
     
    }

  
}
