using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTotal : MonoBehaviour
{
    public float scoreTotal;
    float childCount;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scoreTotal = 0f;
        childCount = 0f; 
        foreach (Transform child in transform)
        {
            if (child.gameObject.activeInHierarchy)
            {
                scoreTotal += child.GetComponent<Scores>().score;
                childCount += 1;
            }
           
        }
        scoreTotal = scoreTotal / childCount;
    }
}
