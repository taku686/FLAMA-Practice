using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSubscriber 
{
    public void RecieveMessage(MessageSignal messageSignal)
    {
        Debug.Log(messageSignal.Message);
    }
}
