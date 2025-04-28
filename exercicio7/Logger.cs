namespace exercicio7;

public class Logger
{
    public static void LogToConsole(string message)
    {
        Console.Write(FormatMessage(message));
    }

    public static void LogToFile(string message)
    {
        Console.WriteLine($"File: O log foi salvo em {Path.GetFullPath("log.txt")}");
        File.AppendAllText("log.txt", FormatMessage(message));
    }

    public static void LogToDatabase(string message)
    {
        Console.Write($"Database (simulado): {FormatMessage(message)}");
    }

    private static string FormatMessage(string message)
    {
        return $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Log: {message}\n";
    }
}