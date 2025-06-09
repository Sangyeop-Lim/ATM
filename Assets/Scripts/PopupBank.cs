using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupBank : MonoBehaviour
{
    [SerializeField] private GameObject atmPanel;
    [SerializeField] private GameObject depositPanel;
    [SerializeField] private GameObject withdrawalPanel;

    [SerializeField] private TMP_InputField depositInput;
    [SerializeField] private TMP_InputField withdrawalInput;

    [SerializeField] private UIUserDisplay uiUserDisplay;
    [SerializeField] private PopupError popupError;

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

    public void OnClickDepositAmount(int amount)
    {
        bool success = GameManager.Instance.Deposit(amount);
        if (!success)
        {
            popupError.Show("현금이 부족합니다.");
            return;
        }

        uiUserDisplay.Refresh();
    }

    public void OnClickWithdrawAmount(int amount)
    {
        bool success = GameManager.Instance.Withdraw(amount);
        if (!success)
        {
            popupError.Show("잔액이 부족합니다.");
            return;
        }

        uiUserDisplay.Refresh();
    }

    public void OnClickDepositAmountFromInput()
    {
        int amount;
        if (!int.TryParse(depositInput.text, out amount) || amount <= 0)
        {
            popupError.Show("유효한 숫자를 입력하세요.");
            return;
        }

        bool success = GameManager.Instance.Deposit(amount);
        if (!success)
        {
            popupError.Show("현금이 부족합니다.");
            return;
        }

        uiUserDisplay.Refresh();
    }

    public void OnClickWithdrawAmountFromInput()
    {
        int amount;
        if (!int.TryParse(withdrawalInput.text, out amount) || amount <= 0)
        {
            popupError.Show("유효한 숫자를 입력하세요.");
            return;
        }

        bool success = GameManager.Instance.Withdraw(amount);
        if (!success)
        {
            popupError.Show("잔액이 부족합니다.");
            return;
        }

        uiUserDisplay.Refresh();
    }
}
