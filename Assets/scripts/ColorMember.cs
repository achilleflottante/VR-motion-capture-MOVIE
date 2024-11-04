using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMember : MonoBehaviour
{
    SkinnedMeshRenderer mr;
    public Transform Point1;
    public Transform Point2;
    float Saturation = 100f;
    float Value = 100f;
    float DistanceMax = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mr = GetComponent<SkinnedMeshRenderer>();
        mr.material.color = Color.HSVToRGB(hue(Vector3.Distance(Point1.position, Point2.position)) / 360f, Saturation / 100f, Value / 100f);
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
