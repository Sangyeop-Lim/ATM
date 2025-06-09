using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupError : MonoBehaviour
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
