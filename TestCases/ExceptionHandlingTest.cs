using System;

public class ExceptionHandlingTest
{
    public void ProcessData()
    {
        try
        {
            DoSomething();
        }
        catch (Exception)
        {
        }
    }

    public void LoadData()
    {
        try
        {
            DoSomething();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error");
        }
    }

    public void SaveData()
    {
        try
        {
            DoSomething();
        }
        catch
        {
            throw;
        }
    }

    private void DoSomething()
    {
        throw new Exception("Something went wrong");
    }
}