using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Line : MonoBehaviour
{
    LineRenderer lr;
    public Transform point;
    float Saturation = 100f;
    float Value = 100f;
    float DistanceMax = 0.8f;
    Distance dist;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        dist = point.gameObject.GetComponent<Distance>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.positionCount = 2;
        lr.SetPosition(0, point.position);
        lr.SetPosition(1, dist.point2.position);
        lr.material.color = Color.HSVToRGB(hue(point.gameObject.GetComponent<Distance>().distance) / 360f, Saturation / 100f, Value / 100f);
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
