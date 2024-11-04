using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutout : MonoBehaviour
{
    public GameObject[] maskobj;

    void Start()
    {
        for (int i = 0; i < maskobj.Length; i++){
            maskobj[i].GetComponent<SkinnedMeshRenderer>().material.renderQueue = 3002;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
