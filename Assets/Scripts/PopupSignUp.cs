using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class PopupSignUp : MonoBehaviour
{
    [SerializeField] private SignUpError signUpError;

    private string path;

    public TMP_InputField inputID;
    public TMP_InputField inputName;
    public TMP_InputField inputPS;
    public TMP_InputField inputPSConfirm;

    public void OnClickSignUp()
    {
        string id = inputID.text;
        string name = inputName.text;
        string password = inputPS.text;
        string passwordConfirm = inputPSConfirm.text;

        if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
        {
            signUpError.Show("모든 입력값을 채워주세요.");
            return;
        }

        if (password != passwordConfirm)
        {
            signUpError.Show("비밀번호와 비밀번호 확인이 일치하지 않습니다.");
            return;
        }

        UserData newUser = new UserData(id, password, name);
        Debug.Log($"회원가입 완료 ID: {newUser.ID}, 이름: {newUser.userName}");

        SaveUserDataToJson(newUser);
    }

    private void SaveUserDataToJson(UserData data)
    {
        string json = JsonUtility.ToJson(data, true);
        path = Application.persistentDataPath + $"/{data.ID}.json";

        File.WriteAllText(path, json);
    }
}
