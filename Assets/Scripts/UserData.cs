using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public string ID;
    public string PS;

    public string userName;
    public int cash;
    public int balance;

    public UserData(string id, string ps, string name)
    {
        this.ID = id;
        this.PS = ps;
        this.userName = name;

        this.cash = 100000;
        this.balance = 50000;
    }

    public UserData(string name, int cash, int balance)
    {
        this.userName = name;
        this.cash = cash;
        this.balance = balance;
    }

    //public bool CheckPassword(string password)
    //{
    //    return PS == password;
    //}
}
