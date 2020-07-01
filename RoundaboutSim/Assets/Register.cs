using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField PasswordInput;
    public InputField PasswordInputConfirm;
    public InputField EmailInput;
    public Button RegButton;

    // Start is called before the first frame update
    void Start()
    {
        RegButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.Web.RegisterUser(UsernameInput.text, PasswordInput.text, EmailInput.text));
        });
    }

    
}
