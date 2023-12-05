using System;
using System.Collections.Generic;

class Program
{
   
    public delegate double BinaryOperation(double operand1, double operand2);

    static void Main()
    {
        Console.WriteLine("Введите математическое выражение в постфиксной форме:");
        string postfixExpression = Console.ReadLine();

        
        double result = EvaluatePostfixExpression(postfixExpression);
        Console.WriteLine($"Результат: {result}");
    }

   
    static double EvaluatePostfixExpression(string expression)
    {
        Stack<double> stack = new Stack<double>();
        string[] tokens = expression.Split(' ');

        
        Dictionary<string, BinaryOperation> operators = new Dictionary<string, BinaryOperation>
        {
            {"+", (a, b) => a + b},
            {"-", (a, b) => a - b},
            {"*", (a, b) => a * b},
            {"/", (a, b) => a / b}
        };

        foreach (string token in tokens)
        {
            if (double.TryParse(token, out double operand))
            {
                
                stack.Push(operand);
            }
            else if (operators.ContainsKey(token))
            {
                
                double operand2 = stack.Pop();
                double operand1 = stack.Pop();
                double result = operators[token](operand1, operand2);
                stack.Push(result);
            }
        }

        
        return stack.Peek();
    }
}