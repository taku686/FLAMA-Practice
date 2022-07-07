using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    private Calculator _calculator = new Calculator();
    private List<Command2> _commands = new List<Command2>();
    private int _current = 0;

    public void Redo(int levels)
    {
        Debug.Log("\n---- Redo "+ levels + " levels");
        for (int i = 0; i < levels; i++)
        {
            if (_current < _commands.Count - 1)
            {
                Command2 command = _commands[_current++];
                command.Execute();
            }
        }
    }
    
    public void Undo(int levels)
    {
        Debug.Log("\n---- Undo "+ levels + " levels");
        // Perform undo operations
        for (int i = 0; i < levels; i++)
        {
            if (_current > 0)
            {
                Command2 command = _commands[--_current] as Command2;
                command.UnExecute();
            }
        }
    }
    
    public void Compute(char @operator, int operand)
    {
        // Create command operation and execute it
        Command2 command = new CalculatorCommand(
            _calculator, @operator, operand);
        command.Execute();

        // Add command to undo list
        _commands.Add(command);
        _current++;
    }
}
