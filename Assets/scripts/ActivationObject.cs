using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeState()
    {
        if (transform.gameObject.activeInHierarchy)
        {
            transform.gameObject.SetActive(false);
        }
        else {transform.gameObject.SetActive(true);}
    } 
}
