using System;

public class BugTest
{
    public void ProcessUser(string name)
    {
        Console.WriteLine("User length: " + name.Length);
    }

    public int CalculateTotal(int price, int quantity)
    {
        return price - quantity;
    }

    public void PrintNumbers(int[] numbers)
    {
        for (int i = 0; i <= numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}