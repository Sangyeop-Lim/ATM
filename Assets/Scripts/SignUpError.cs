using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SignUpError : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Show(string message)
    {
        gameObject.SetActive(true);
        messageText.text = message;
    }

    public void OnClickConfirm()
    {
        gameObject.SetActive(false);
    }
}
