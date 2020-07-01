using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finishManager : MonoBehaviour
{
    public Text scoreTxt;
    public int score;
    public void Start()
    {
        score = score + 1;
        scoreTxt.text = "Score : " + score;
    }
    public void Play()
    {
        SceneManager.LoadScene("RoundaboutSim");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("RoundaboutSimL2");
    }

    void OnEnable()
    {
        score = PlayerPrefs.GetInt("score");
    }
}
