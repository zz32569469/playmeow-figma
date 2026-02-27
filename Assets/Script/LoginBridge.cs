using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginBridge : MonoBehaviour
{   
    public static LoginBridge Instance {get; private set;}
    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
    }

    [SerializeField]
    LoginModel model;
    [SerializeField]
    LoginUI ui;

    public void OnLoginClick()
    {
        if (model.TryLogin(ui.GetData()))
        {
            //登入成功
        }
        else
        {
            ui.ShowLoginFailed();
        }
    }
}
