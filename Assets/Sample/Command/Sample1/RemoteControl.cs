using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteControl
{
    private readonly List<ICommand> _commands = new List<ICommand>();

    public void ExecuteAllCommands()
    {
        Debug.Log("手持ちのコマンドを全部実行しますよ");
        _commands.ForEach(x => x.execute());
    }

    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
        Debug.Log("コマンドを追加しました");
    }
}