using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finishManager : MonoBehaviour
{
    public Text scoreTxt;
    public int score;
    public Text messageTxt;

    public void Start()
    {
        messageTxt.text = (PlayerPrefs.GetString("username"));
        //score = score + 1;
        if(score < 6)
        {
            messageTxt.text = (PlayerPrefs.GetString("username") + " you should retry this level");
        }
        else
        {
            messageTxt.text = (PlayerPrefs.GetString("username") + " you got a perfect score");
        }
        scoreTxt.text = "Score : " + score + "/6";
        PlayerPrefs.SetInt("score", score);
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().PlayMusic();
        StartCoroutine(Main.Instance.Web.SaveScore());
    }
    public void Play()
    {
        SceneManager.LoadScene("RoundaboutSim");
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().StopMusic();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("RoundaboutSimL2");
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().StopMusic();
    }

    void OnEnable()
    {
        score = PlayerPrefs.GetInt("score");
    }
}
