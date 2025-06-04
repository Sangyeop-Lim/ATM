using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public string userName;
    public int cash;
    public int balance;

    public UserData(string name, int cash, int balance)
    {
        this.userName = name;
        this.cash = cash;
        this.balance = balance;
    }
}
