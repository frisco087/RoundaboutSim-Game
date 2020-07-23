using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
   
    public Text messageTxt;

    void Start()
    {
        messageTxt.text = ("Welcome " + PlayerPrefs.GetString("username"));
        
    }

    public void Play()
    {
        SceneManager.LoadScene("RoundaboutSim");
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().StopMusic();

    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
  
    public void Exit()
    {
        Application.Quit();
    }
   
}
