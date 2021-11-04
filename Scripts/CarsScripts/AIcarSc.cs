using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcarSc : MonoBehaviour
{
    public float Speed;

    public float SideSpeed;
    public bool ChangeLine;
    public int LineIndex;

    public float ChangeLineTimer;
    public float GetChange;

    public int CanChangeLines;
    void Start()
    {
        Speed = Random.Range(10, 20);
        CanChangeLines = Random.Range(0, 4);
    }


    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        transform.Translate(SideSpeed * Time.deltaTime,0,0);
        if (CanChangeLines >= 1)
        {
            SelectLine();
        }
        

    }

    public void SelectLine()
    {
        ChangeLineTimer += Time.deltaTime;
        if(ChangeLineTimer >= GetChange)
        {
            SideSpeed = Random.Range(-5, 5);
            LineIndex = Random.Range(0, 5);
            ChangeLineTimer = 0;
            //GetChange = 600;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            this.enabled = false;
            
        }
       if(collision.gameObject.tag == "Car")
        {
            SideSpeed *= -1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(LineIndex == 0)
        {
            if (other.gameObject.name == "Leftest")
            {
                SideSpeed = 0;
            }
        }
        if (LineIndex == 1)
        {
            if (other.gameObject.name == "Left")
            {
                SideSpeed = 0;
            }
        }
        if (LineIndex == 2)
        {
            if (other.gameObject.name == "Mid")
            {
                SideSpeed = 0;
            }
        }
        if (LineIndex == 3)
        {
            if (other.gameObject.name == "Right")
            {
                SideSpeed = 0;
            }
        }
        if (LineIndex == 4)
        {
            if (other.gameObject.name == "Rightest")
            {
                SideSpeed = 0;
            }
        }
    }
}
