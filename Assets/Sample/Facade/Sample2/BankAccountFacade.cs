using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankAccountFacade
{
    private int _accountNumber;
    private int _securityCode;
    private AccountNumberCheck _accChecker;
    private SecurityCodeCheck _codeChecker;
    private FundsCheck _fundChecker;
    private WelcomeToBank _bankWelcome;

    public BankAccountFacade(int accountNumber, int newSecurityCode)
    {
        this._accountNumber = accountNumber;
        _securityCode = newSecurityCode;

        _bankWelcome = new WelcomeToBank();
        _codeChecker = new SecurityCodeCheck();
        _accChecker = new AccountNumberCheck();
        _fundChecker = new FundsCheck();
    }

    public int GetAccountNumber()
    {
        return _accountNumber;
    }

    public int GetSecurityCode()
    {
        return _securityCode;
    }

    public void WithdrawCash(double cash)
    {
        if (_accChecker.AccountActive(GetAccountNumber())
            && _codeChecker.IsCodeCorrect(GetSecurityCode())
            && _fundChecker.HaveEnoughMoney(cash))
        {
            _fundChecker.WithdrawMoney(cash);
            Debug.Log("Transaction complete.");
        }
        else
        {
            Debug.Log("Transaction failed.");
        }
    }

    public void DepositCash(double cash)
    {
        if (_accChecker.AccountActive(GetAccountNumber())
            && _codeChecker.IsCodeCorrect(GetSecurityCode()))
        {
            _fundChecker.MakeDeposit(cash);
            Debug.Log("Transaction complete.");
        }
        else
        {
            Debug.Log("Transaction failed.");
        }
    }
}