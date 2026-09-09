using System;

public class BugTest
{
    public void ProcessUser(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return;
        }

        Console.WriteLine("User length: " + name.Length);
    }

    public int CalculateTotal(int price, int quantity)
    {
        return price * quantity;
    }

    public void PrintNumbers(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}