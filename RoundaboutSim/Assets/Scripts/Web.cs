using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Web : MonoBehaviour
{
    public Text messageTxt;
    public Text messageTxt2;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(GetUsers());
        //StartCoroutine(Login("test","123"));
        //StartCoroutine(RegisterUser("daniel1", "fff", "yo@yo.com"));
    }

   IEnumerator GetUsers() {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/RoundaboutSimUnityBackend/GetUsers.php")) {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError) {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                byte[] results = www.downloadHandler.data;
            }
        }
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/RoundaboutSimUnityBackend/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text == "Login Success.")
                {
                    PlayerPrefs.SetString("username", username);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else
                {
                    messageTxt.text = www.downloadHandler.text;
                }
                
            }
        }
    }

    public IEnumerator RegisterUser(string username, string password, string password2, string email)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        form.AddField("loginPass2", password2);
        form.AddField("loginEmail", email);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/RoundaboutSimUnityBackend/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text == "Passwords don't match")
                {
                    messageTxt2.text = www.downloadHandler.text; 
                }
                else if (www.downloadHandler.text == "Username taken")
                {
                    messageTxt2.text = www.downloadHandler.text;
                }
                else
                {
                    PlayerPrefs.SetString("username", username);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }                 
            }
        }
    }

    public IEnumerator SaveScore()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", PlayerPrefs.GetString("username"));
        string scoreStr = PlayerPrefs.GetInt("score").ToString();
        form.AddField("score",scoreStr);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/RoundaboutSimUnityBackend/SaveScore.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
               
            }
        }
    }
}
