using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PopupLogin : MonoBehaviour
{
    [SerializeField] GameObject signUp;

    private void Start()
    {
        signUp.SetActive(false);
    }

    public void OnClickSignUp()
    {
        signUp.SetActive(true);
    }

    public void OnClickCancle()
    {
        signUp.SetActive(false);
    }
}
