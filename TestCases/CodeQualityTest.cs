using System;

public class CodeQualityTest
{
    public void DoSomething(int x)
    {
        int a = x * 100;
        int b = x * 100;
        int c = x * 100;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        if (x > 500)
        {
            Console.WriteLine("Large value");
        }

        if (x > 500)
        {
            Console.WriteLine("Large value");
        }
    }

    public string getuserData(string n)
    {
        if (n == null)
        {
            return "";
        }

        return n;
    }
}