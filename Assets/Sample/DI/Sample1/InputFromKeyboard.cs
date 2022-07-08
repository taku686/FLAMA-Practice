using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputFromKeyboard : IInputtable
{
    public Vector3 InputForMove()
    {
        var gamePad = Gamepad.current;
        var input = gamePad.leftStick.ReadValue();
        if (input.magnitude > 0)
        {
            Debug.Log(new Vector3(input.x, 0, input.y));
            return new Vector3(input.x, 0, input.y);
        }
        else
        {
            return Vector3.zero;
        }
    }
}