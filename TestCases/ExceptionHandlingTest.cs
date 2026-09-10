using System;

public class ExceptionHandlingTest
{
    public void ProcessData()
    {
        try
        {
            DoSomething();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing data: {ex.Message}");
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
            Console.WriteLine($"Error loading data: {ex.Message}");
        }
    }

    public void SaveData()
    {
        try
        {
            DoSomething();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
            throw;
        }
    }

    private void DoSomething()
    {
        throw new Exception("Something went wrong");
    }
}