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
        childCount = (float)transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTotal = 0f;
        foreach (Transform child in transform)
        {
            scoreTotal += child.GetComponent<Scores>().score / childCount;
        }
    }
}
