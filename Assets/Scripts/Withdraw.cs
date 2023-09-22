using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //인풋 필드 쓰려면 필요함.

public class Widraw : MonoBehaviour
{
    [SerializeField] private Text CurrentBalance;
    [SerializeField] private Text CurrentWallet;
    [SerializeField] private InputField inputTxT_Money;
    public int Current_Money;
    public int Current_Wallet;
    public GameObject PopUp;
    // Start is called before the first frame update
    public void Start()
    {
        if (CurrentBalance != null && inputTxT_Money != null)
        {
            Current_Money = int.Parse(CurrentBalance.text);
        }
        if (CurrentWallet != null && inputTxT_Money != null)
        {
            Current_Wallet = int.Parse(CurrentWallet.text);
        }
    }
    public void Output() //출금
    {
        if (Current_Money >= int.Parse(inputTxT_Money.text))
        {
            Debug.Log("check>=0");
            Current_Money -= int.Parse(inputTxT_Money.text); //문자형 숫자를 int형 숫자로 바꿔줌.
            CurrentBalance.text = Current_Money.ToString(); //int타입을 string 타입으로 바꾸어 화면에 반영.
            Current_Wallet += int.Parse(inputTxT_Money.text);
            CurrentWallet.text = Current_Wallet.ToString();
        }
        else if (Current_Money < int.Parse(inputTxT_Money.text))
        {
            Debug.Log("check<0");
            PopUp.SetActive(true);
        }

    }

    public void Withdraw_1()
    {

        if (Current_Money >= 10000)
        {
            Debug.Log("check>=0");
            Current_Money -= 10000;
            CurrentBalance.text = Current_Money.ToString();
            Current_Wallet += 10000;
            CurrentWallet.text = Current_Wallet.ToString();
        }

        else if (Current_Money < 10000)
        {
            Debug.Log("check<0");
            PopUpOn();
        }

    }
    public void Withdraw_3()
    {
        if (Current_Money >= 30000)
        {
            Debug.Log("check>=0");
            Current_Money -= 30000;
            CurrentBalance.text = Current_Money.ToString();
            Current_Wallet += 30000;
            CurrentWallet.text = Current_Wallet.ToString();
        }

        else if (Current_Money < 30000)
        {
            Debug.Log("check<0");
            PopUpOn();
        }
    }
    public void Withdraw_5()
    {
        if (Current_Money >= 50000)
        {
            Debug.Log("check>=0");
            Current_Money -= 50000;
            CurrentBalance.text = Current_Money.ToString();
            Current_Wallet += 50000;
            CurrentWallet.text = Current_Wallet.ToString();
        }

        else if (Current_Money < 50000)
        {
            Debug.Log("check<0");
            PopUpOn();
        }
    }


    public void PopUpOn()
    {
        PopUp.SetActive(true);
    }
    public void PopUpOff()
    {
        PopUp.SetActive(false);
    }
}