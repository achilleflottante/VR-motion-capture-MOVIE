using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Line : MonoBehaviour
{
    LineRenderer lr;
    public Transform Point1;
    public Transform Point2;
    float Saturation = 100f;
    float Value = 100f;
    float DistanceMax = 0.8f;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.positionCount = 2;
        lr.SetPosition(0, Point1.position);
        lr.SetPosition(1, Point2.position);
        lr.material.color = Color.HSVToRGB(hue(Vector3.Distance(Point1.position, Point2.position)) / 360f, Saturation / 100f, Value / 100f);
    }
    float hue(float distance)
    {
        float h;
        if (distance > DistanceMax)
        {
            h = 0;
        }
        else
        {
            h = (1 - distance / DistanceMax) * 120;
        }
        return h;
    }
}
