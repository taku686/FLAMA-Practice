using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCodeCheck 
{
    private int securityCode = 1234;

    public int GetSecurityCode()
    {
        return securityCode;
    }

    public bool IsCodeCorrect(int code)
    {
        if (code == securityCode)
            return true;
        else
            return false;
    }
}