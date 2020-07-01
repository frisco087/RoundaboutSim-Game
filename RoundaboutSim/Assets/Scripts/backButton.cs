using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButton : MonoBehaviour
{
    public void BackButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
