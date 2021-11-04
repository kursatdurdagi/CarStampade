using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPicker : MonoBehaviour
{
    public CharacterMain cm;
    public GameObject Cirlce;

    public Material CarMat;
    public Material Highlited;

    void Start()
    {
        
    }


    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position, cm.gameObject.transform.position + new Vector3(0,0,5), 1f);
        cm.Picker = this.gameObject;
        Cirlce.transform.Rotate(0, 150 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Car")
        {
            //CarMat = other.gameObject.GetComponent<MeshRenderer>().material;
            other.gameObject.GetComponent<MeshRenderer>().material = Highlited;
            cm.PickedCar = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {

            other.gameObject.GetComponent<MeshRenderer>().material = other.gameObject.GetComponent<JoystickPlayerExample>().MyMat;
            cm.PickedCar = null;
        }
    }
}
