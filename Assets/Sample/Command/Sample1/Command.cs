using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : ICommand
{
    public void execute()
    {
        Debug.Log("コマンドを実行していますよ!!");
    }
}