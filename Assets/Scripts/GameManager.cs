using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public UserData userData;

    private string path;

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

        path = Application.persistentDataPath + "/UserData.json";

        LoadUserData();
    }

    public void SaveUserData()
    {
        string json = JsonUtility.ToJson(userData);
        File.WriteAllText(path, json);
        Debug.Log("데이터 저장됨: " + path);
    }

    public void LoadUserData()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            userData = JsonUtility.FromJson<UserData>(json);
            Debug.Log("데이터 불러옴: " + json);
        }
        else
        {
            Debug.Log("저장된 파일이 없습니다. 기본값 사용");
            GameManager.Instance.userData = new UserData("임상엽", 100000, 50000);
        }
    }

    public bool Deposit(int amount)
    {
        if (userData.cash >= amount)
        {
            userData.cash -= amount;
            userData.balance += amount;
            
            SaveUserData();
            
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
            
            SaveUserData();
            
            return true;
        }

        return false;
    }
}
