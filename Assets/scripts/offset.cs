using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offset : MonoBehaviour
{
    [SerializeField]
    public float offsetx;
    public float offsety;
    public float offsetz;
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
        transform.position = transform.position + new Vector3(offsetx, offsety, offsetz);
        Vector3 rotationVector = transform.eulerAngles + new Vector3(tiltx, tilty, tiltz);
        
        transform.rotation = Quaternion.Euler(rotationVector);
       
    }
}
