using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetController : MonoBehaviour
{
    public float tiltx;
    public float tilty;
    public float tiltz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationVector = transform.localEulerAngles + new Vector3(tiltx, tilty, tiltz);
        transform.localRotation = Quaternion.Euler(rotationVector);
    }
}