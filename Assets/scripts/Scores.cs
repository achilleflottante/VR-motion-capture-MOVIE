using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scores : MonoBehaviour
{
    TMP_Text myText;
    string myTextFixe;
    public Transform point;
    float DistanceMax = 0.8f;
    public float score;
    Distance dist;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TMP_Text>();
        myTextFixe = GetComponent<TMP_Text>().text;
        dist = point.gameObject.GetComponent<Distance>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dist.distance < DistanceMax)
        {
            score = 100f * (1f - dist.distance/DistanceMax);
        }
        else { score = 0f; };
        myText.text = myTextFixe + " : " + score ;
    }
}
