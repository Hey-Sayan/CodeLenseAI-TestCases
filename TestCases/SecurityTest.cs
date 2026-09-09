using System;

public class SecurityTest
{
    public void FindUser(string userId)
    {
        string query = "SELECT * FROM Users WHERE Id = '" + userId + "'";

        Console.WriteLine(query);
    }

    public void SaveConfiguration()
    {
        string apiKey = "sk-test-123456789-secret-key";

        Console.WriteLine(apiKey);
    }

    public void ExecuteCommand(string userInput)
    {
        string command = "ping " + userInput;

        Console.WriteLine(command);
    }
}