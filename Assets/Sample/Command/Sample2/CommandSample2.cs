using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandSample2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create user and let her compute
        User user = new User();

        // User presses calculator buttons
        user.Compute('+', 100);
        user.Compute('-', 50);
        user.Compute('*', 10);
        user.Compute('/', 2);

        // Undo 4 commands
        user.Undo(4);

        // Redo 3 commands
        user.Redo(3);
    }
}