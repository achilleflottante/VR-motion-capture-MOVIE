using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public int step = 1;
    public float score;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
    public GameObject lines;
    public GameObject Hips;
    public GameObject RArm;
    public GameObject LArm;
    public GameObject RHand;
    public GameObject LHand;
    public GameObject Head;
    public GameObject mirror;
    private AudioSource source;
    public GameObject instruction1;
    public GameObject instruction2;
    public GameObject instruction3;
    public GameObject instruction4;
    public GameObject pannel;
    GameObject inst;
    float compt = 0;
    public float scoreMin;
    bool comptActive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("EmptyScores").GetComponent<ScoreTotal>().scoreTotal;
        inst  = instruction1;
        //source = GetComponent<AudioSource>;
        //source.PlayOneShot(audio1);
    }

    // Update is called once per frame
    void Update()
    {
        compt += Time.deltaTime;
        if (comptActive) {
            if (compt > 2f)
            {
                pannel.SetActive(false);
                inst.SetActive(false);
                mirror.SetActive(true);
                comptActive = false;
            }
        }
        if ((step == 1) & (score > scoreMin))
        {
            pannel.SetActive(true);
            mirror.SetActive(false);
            step += 1;
            //source.PlayOneShot(audio2);
            inst = instruction2;
            inst.SetActive(true);
            Hips.SetActive(true);
            compt = 0;
            comptActive = true;
        }
        if ((step == 2) & (score > scoreMin))
        {
            //source.PlayOneShot(audio3);
            pannel.SetActive(true);
            mirror.SetActive(false);
            step += 1;
            inst = instruction3;
            inst.SetActive(true);
            RArm.SetActive(true);
            LArm.SetActive(true);
            RHand.SetActive(true);
            LHand.SetActive(true);
            Head.SetActive(true);
            compt = 0;
            comptActive = true;
        }
        if ((step == 3) & (score > scoreMin))
        {
            //source.PlayOneShot(audio4);
            pannel.SetActive(true);
            inst = instruction4;
            inst.SetActive(true);
            compt = 0;
            comptActive = true;
        }
    }
    public void resetStep ()
    {   
        pannel.SetActive(true);
        mirror.SetActive(false);
        step = 1;
        Hips.SetActive(false);
        RArm.SetActive(false);
        LArm.SetActive(false);
        RHand.SetActive(false);
        LHand.SetActive(false);
        Head.SetActive(false);
        inst = instruction1;
        inst.SetActive(true);
        compt = 0;
        comptActive = true;
    }
}