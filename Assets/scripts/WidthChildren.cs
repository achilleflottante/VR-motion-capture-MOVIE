using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidthChildren : MonoBehaviour
{   public float width;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform){
            LineRenderer lr = child.GetComponent<LineRenderer>();
            lr.SetWidth(width, width); 
        }
    }
}
