using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AffichageScoreTotal : MonoBehaviour
{
    TMP_Text myText;
    string myTextFixe;
    Transform sibling;
    public ScoreTotal score;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TMP_Text>();
        myTextFixe = GetComponent<TMP_Text>().text;
        sibling = transform.parent.Find("EmptyScores");
        if (sibling == null)
        {
            Debug.LogError("EmptyScores not found in the parent object.");
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        score = sibling.gameObject.GetComponent<ScoreTotal>();
        if (score == null)
        {
            Debug.LogError("ScoreTotal component not found on EmptyScores.");
            return; // Sortir de la méthode si score est nul
        }
        myText.text = myTextFixe + " : " + score.scoreTotal;
    }
}
