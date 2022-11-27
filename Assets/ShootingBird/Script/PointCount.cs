using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
{
    public static int PointValue = 0;
    Text point;


    // Start is called before the first frame update
    void Start()
    {
        point = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        point.text = "Point: " + PointValue;
    }

}
