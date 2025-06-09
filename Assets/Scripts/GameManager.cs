using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public UserData userData;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        userData = new UserData("임상엽", 100000, 50000);
    }

    public bool Deposit(int amount)
    {
        if (userData.cash >= amount)
        {
            userData.cash -= amount;
            userData.balance += amount;
            return true;
        }

        return false;
    }

    public bool Withdraw(int amount)
    {
        if (userData.balance >= amount)
        {
            userData.balance -= amount;
            userData.cash += amount;
            return true;
        }

        return false;
    }
}
