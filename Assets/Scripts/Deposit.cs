using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deposit : MonoBehaviour
{
    //어떻게 가져오는거지 ?????
    [SerializeField] private Text CurrentBalance;
    [SerializeField] private Text CurrentWallet;
    [SerializeField] private InputField inputTxT_Money;
    public int Current_Money;
    public int Current_Wallet;
    public GameObject PopUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Deposit_1()
    {
        int rest = Current_Wallet- 10000;
        if (Current_Wallet <= rest)
        {
            Debug.Log("check>=0");
            Current_Money += 10000;
            CurrentBalance.text = Current_Money.ToString();
            Current_Wallet -= 10000;
            CurrentWallet.text = Current_Wallet.ToString();
        }
        else if (Current_Wallet > rest)
        {
            Debug.Log("check<0");
            PopUpOn();
        }
    }
    public void Deposit_3()
    {
        int rest = Current_Wallet - 30000;
        if (Current_Wallet <= rest)
        {
            Current_Money += 30000;
            CurrentBalance.text = Current_Money.ToString();
            Current_Wallet -= 30000;
            CurrentWallet.text = Current_Wallet.ToString();
        }
        else if (Current_Wallet > rest)
        {
            PopUpOn();
        }
    }
    public void Deposit_5()
    {
        int rest = Current_Wallet - 50000;
        if (Current_Wallet <= rest)
        {
            Current_Money += 50000;
            CurrentBalance.text = Current_Money.ToString();
            Current_Wallet -= 50000;
            CurrentWallet.text = Current_Wallet.ToString();
        }
        else if (Current_Wallet > rest)
        { 
            PopUpOn();
        }
    }

    public void PopUpOn()
    {
        PopUp.SetActive(true);
    }
}
