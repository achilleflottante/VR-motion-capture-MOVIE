using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scores : MonoBehaviour
{
    TMP_Text myText;
    string myTextFixe;
    public Transform Point1;
    public Transform Point2;
    float DistanceMax = 5f;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TMP_Text>();
        myTextFixe = GetComponent<TMP_Text>().text;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Point1.position, Point2.position);
        if (distance < DistanceMax)
        {
            score = 100f * (1 - distance/DistanceMax);
        }
        else { score = 0f; };
        myText.text = myTextFixe + " : " + score ;
    }
}
