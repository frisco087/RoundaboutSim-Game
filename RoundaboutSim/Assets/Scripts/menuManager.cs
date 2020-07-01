using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("RoundaboutSim");
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
