using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBank : MonoBehaviour
{
    [SerializeField] private GameObject atmPanel;
    [SerializeField] private GameObject depositPanel;
    [SerializeField] private GameObject withdrawalPanel;

    public void OnClickDeposit()
    {
        atmPanel.SetActive(false);
        depositPanel.SetActive(true);
    }

    public void OnClickWithdrawal()
    {
        atmPanel.SetActive(false);
        withdrawalPanel.SetActive(true);
    }

    public void OnClickBackFromDeposit()
    {
        depositPanel.SetActive(false);
        atmPanel.SetActive(true);
    }

    public void OnClickBackFromWithdrawal()
    {
        withdrawalPanel.SetActive(false);
        atmPanel.SetActive(true);
    }
}
