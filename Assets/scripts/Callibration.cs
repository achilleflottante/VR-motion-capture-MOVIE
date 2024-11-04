using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Callibration : MonoBehaviour
{
    public float compt = 0f;
    public Vector3 calibrot;
    [SerializeField]

    public GameObject reference;
    // Start is called before the first frame update

    void Calibration(){
        calibrot = -1*transform.rotation.eulerAngles + reference.transform.rotation.eulerAngles;
        


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetAxis("Jump")>0.99f){
            compt += Time.deltaTime;
        }
        if (compt > 3f) {
           Calibration();
           compt = 0f;
           Debug.Log("Calibrated");
        }
        
        Vector3 rotationVector = transform.rotation.eulerAngles + calibrot;
        transform.rotation = Quaternion.Euler(rotationVector);
            
    
        
    
  

    }
}
    