using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMain : MonoBehaviour
{
    public GameObject PickedCar;
    public GameObject Picker;
    public bool GoToCar;

    public GameObject fuelImage;
    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GoToCar = true;
        }
        fuelImage = GameObject.Find("Fualimage");

    }

    private void FixedUpdate()
    {
        
        if (GoToCar && PickedCar != null)
        {
            transform.position = Vector3.Lerp(transform.position, PickedCar.transform.position, 0.1f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            fuelImage.GetComponent<Image>().enabled = true;
            fuelImage.GetComponent<Image>().transform.GetChild(0).GetComponent<Image>().enabled = true;
            Destroy(this.gameObject);
            collision.gameObject.tag = "Player";
            collision.gameObject.GetComponent<JoystickPlayerExample>().enabled = true;
            Destroy(Picker);
           
        }
    }
}
