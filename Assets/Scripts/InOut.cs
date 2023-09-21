using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //인풋 필드 쓰려면 필요함.

public class InOut : MonoBehaviour
{

    [SerializeField] private Text CurrentBalance;
    [SerializeField] private Text CurrentWallet;
    [SerializeField] private InputField inputTxT_Money;
    private int Current_Money;
    private int Current_Wallet;
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
    public void Input() //입금
    {
        if(Current_Wallet>=int.Parse(inputTxT_Money.text))
        {
            Current_Money += int.Parse(inputTxT_Money.text); //입력받은 문자형 숫자를 int형 숫자로 바꿔줌.
            CurrentBalance.text = Current_Money.ToString(); //int타입을 string 타입으로 바꾸어 화면에 반영.
            Debug.Log("check>=0");
            Current_Wallet -= int.Parse(inputTxT_Money.text);
            CurrentWallet.text = Current_Wallet.ToString();
            //PopUp.SetActive(true);
        }
        else if(Current_Wallet < int.Parse(inputTxT_Money.text))
        {
            Debug.Log("check<0");
        }
    }

    public void Output() //출금
    {

        Current_Money -= int.Parse(inputTxT_Money.text); //문자형 숫자를 int형 숫자로 바꿔줌.

        CurrentBalance.text = Current_Money.ToString(); //int타입을 string 타입으로 바꿔줌

    }
}