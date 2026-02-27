using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginModel : MonoBehaviour
{   
    public bool TryLogin((string acc, string pass) data)
    {
        //if(data.acc and data.pass are correct) return true;
        Debug.Log($"{data.acc}, {data.pass}");
        return false;
    }
}
