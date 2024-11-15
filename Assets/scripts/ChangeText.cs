using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{   
    public TMP_Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeText ()
    {
        if (myText.text == "Oui") {
            myText.text = "Non";
        }
        else {
            myText.text = "Oui";
        }
    }
}
