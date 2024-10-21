using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offset : MonoBehaviour
{
    [SerializeField]
    public int offsetcam;
    // Start is called before the first frame update
    void Start()
    {
         transform.position = transform.position + new Vector3(0, offsetcam, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, offsetcam, 0);
       
    }
}
