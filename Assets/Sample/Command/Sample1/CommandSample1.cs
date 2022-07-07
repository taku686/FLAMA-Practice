using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandSample1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var remoteControl = new RemoteControl();
        remoteControl.AddCommand(new Command());
        remoteControl.ExecuteAllCommands();
        remoteControl.AddCommand(new  Command());
        remoteControl.ExecuteAllCommands();
    }
}
