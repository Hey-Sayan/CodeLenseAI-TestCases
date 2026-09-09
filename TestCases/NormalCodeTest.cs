using System;

public class NormalCodeTest
{
    public int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public string GetGreeting(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "Hello!";
        }

        return $"Hello, {name}!";
    }

    public bool IsAdult(int age)
    {
        return age >= 18;
    }

    public void PrintMessage(string message)
    {
        if (!string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine(message);
        }
    }
}