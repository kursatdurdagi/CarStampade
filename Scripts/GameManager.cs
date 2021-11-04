using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject inGameMenu;
    public GameObject RestartMenu;

    public bool isStart;
    public bool isLose;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void StartGame()
    {
        MainMenu.SetActive(false);
        inGameMenu.SetActive(true);
        isStart = true;
    }
}
