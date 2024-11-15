using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMember : MonoBehaviour
{
    SkinnedMeshRenderer mr;
    public Transform point;
    float Saturation = 100f;
    float Value = 100f;
    float DistanceMax = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mr = GetComponent<SkinnedMeshRenderer>();
        mr.material.color = Color.HSVToRGB(hue(point.gameObject.GetComponent<Distance>().distance) / 360f, Saturation / 100f, Value / 100f);
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
