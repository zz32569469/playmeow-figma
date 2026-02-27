using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginUI : MonoBehaviour
{   
    [SerializeField]
    Button LoginButton;
    [SerializeField]
    TMP_InputField accountInput, passwordInput;
    [SerializeField]
    GameObject FailedLoginTip;

    void Start()
    {
        LoginButton.onClick.AddListener(() => {LoginBridge.Instance.OnLoginClick();});
    }

    public (string, string) GetData()
    {
        return (accountInput.text, passwordInput.text);
    }

    public void ShowLoginFailed()
    {
        FailedLoginTip?.SetActive(true);
    }
}
