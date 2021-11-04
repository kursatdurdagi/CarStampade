using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAnimControl : MonoBehaviour
{

    public Animator CamAnimator;

    JoystickPlayerExample jpe;
    void Start()
    {
        jpe = GetComponent<JoystickPlayerExample>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "StartPlayer")
        {
            CamAnimator.SetBool("inGame", true);
            CamAnimator.gameObject.GetComponent<PlayerFollow>().enabled = true;
            jpe.enabled = true;
        }
    }
}
