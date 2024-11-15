using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform pointReception;
    public Transform pointServe;
    public Transform pointForehand;
    public Transform pointBackhand;
    public float distance;
    public Transform point2;
    // Start is called before the first frame update
    void Start()
    {
        if (pointReception.gameObject.activeInHierarchy)
        {
            point2 = pointReception;
        }
        else if (pointServe.gameObject.activeInHierarchy)
        {
            point2 = pointServe;
        }
        else if (pointForehand.gameObject.activeInHierarchy)
        {
            point2 = pointForehand;
        }
        else
        {
            point2 = pointBackhand;
        }
        distance = Vector3.Distance(transform.position, point2.position);
        //GameObject reception = GameObject.Find("Reception");
        //GameObject serve= GameObject.Find("Serve");
        //GameObject forehand = GameObject.Find("Forehand");
        //GameObject backhand= GameObject.Find("Backhand");
    }

    // Update is called once per frame
    void Update()
    {
        if (pointReception.gameObject.activeInHierarchy)
        {
            point2 = pointReception;
        }
        else if (pointServe.gameObject.activeInHierarchy)
        {
            point2 = pointServe;
        }
        else if (pointForehand.gameObject.activeInHierarchy)
        {
            point2 = pointForehand;
        }
        else
        {
            point2 = pointBackhand;
        }
        distance = Vector3.Distance(transform.position, point2.position);
    }
}
