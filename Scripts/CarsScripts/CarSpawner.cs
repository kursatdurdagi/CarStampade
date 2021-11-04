using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    GameManager gm;


    public float SpawnTimer;
    public float GetSpawn;

    public int CarIndex;
    public int SpawnerIndex;

    public Transform[] SpawnPoint;

    public GameObject[] Cars;

    public GameObject player;
    public float Speed;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Update()
    {
        if(gm.isStart)
        {
            SpawnCar();
        }
       
        //if(GameObject.FindWithTag("Player").GetComponent<JoystickPlayerExample>() != null)
        //{
        //    Speed = GameObject.FindWithTag("Player").GetComponent<JoystickPlayerExample>().ForwardSpeed;
        //}
        //else
        //{
        //    Speed = 40;
        //}
        //transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        
    }

    public void SpawnCar()
    {
        SpawnTimer += Time.deltaTime;
        if(SpawnTimer >= GetSpawn)
        {
            CarIndex = Random.Range(0, Cars.Length);
            SpawnerIndex = Random.Range(0, SpawnPoint.Length);
            Instantiate(Cars[CarIndex], SpawnPoint[SpawnerIndex].transform.position, SpawnPoint[SpawnerIndex].transform.rotation);
            SpawnTimer = 0;
        }
    }
}
