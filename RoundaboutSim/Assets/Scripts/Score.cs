using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Correct")
        {
            Debug.Log("Correct");
            score = score + 1;
            scoreTxt.text = "Score : " + score;
        }
        else if
         (other.tag == "Incorrect")
        {
            Debug.Log("incorrect");
            score = score - 1;
            scoreTxt.text = "Score : " + score;
        }

    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("score", score);
    }
   
}
