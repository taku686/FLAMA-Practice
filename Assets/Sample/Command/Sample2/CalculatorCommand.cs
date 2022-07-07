using System;

public class CalculatorCommand : Command2
{
    private char _operator;
    private int _operand;

    public int Operand
    {
        set => _operand = value;
    }

    private Calculator _calculator;

    public char Operator
    {
        set => _operator = value;
    }

    public CalculatorCommand(Calculator calculator, char @operator, int operand)
    {
        this._calculator = calculator;
        this._operator = @operator;
        this._operand = operand;
    }

    public override void Execute()
    {
        _calculator.Operation(Undo(_operator),_operand);
    }

    public override void UnExecute()
    {
        _calculator.Operation(Undo(_operator), _operand);
    }
    
    private char Undo(char @operator)
    {
        switch (@operator)
        {
            case '+': return '-';
            case '-': return '+';
            case '*': return '/';
            case '/': return '*';
            default:
                throw new
                    ArgumentException("@operator");
        }
    }
}