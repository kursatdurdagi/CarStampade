using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculateDistacne : MonoBehaviour
{
    public Transform StartPoint;
    public float Distance;
    public TMP_Text DistanceText;
    void Start()
    {
        
    }


    void Update()
    {
        Distance = Vector3.Distance(StartPoint.position, transform.position);
        DistanceText.text = Distance.ToString("00") + "M";

        
    }
}
