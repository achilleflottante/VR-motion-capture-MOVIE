using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class tracking : MonoBehaviour
{
    public Vector3 calibpos;
    public Vector3 calibrot;

    [SerializeField]
    public float offsetx;
    public float offsety;
    public float offsetz;
    public float tiltx;
    public float tilty;
    public float tiltz;
    public  GameObject tracker;
    // Start is called before the first frame update
    void Start()
    {
       calibpos = tracker.transform.position;
       calibrot = tracker.transform.eulerAngles;
        
    }
    // Update is called once per frame
    void Update()
    {
        calibpos = tracker.transform.position;
        calibrot = tracker.transform.eulerAngles;
        transform.position = calibpos + new Vector3(offsetx, offsety, offsetz);
        Vector3 rotationVector = calibrot + new Vector3(tiltx, tilty, tiltz);
        
        transform.rotation = Quaternion.Euler(rotationVector);
       
    }
}