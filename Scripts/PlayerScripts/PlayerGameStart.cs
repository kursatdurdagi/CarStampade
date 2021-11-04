using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameStart : MonoBehaviour
{
    GameManager gm;
    public Animator playerAnimator;
    public float speed;
    public GameObject Character;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Update()
    {
        if(gm.isStart)
        {
            playerAnimator.SetBool("Run", true);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Car1")
        {
            transform.rotation = Quaternion.identity;
            Character.SetActive(false);
            speed = 0;
            this.enabled = false;
        }
    }
}
