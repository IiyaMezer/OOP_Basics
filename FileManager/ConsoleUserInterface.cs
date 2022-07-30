namespace FileManager;

public class ConsoleUserInterface : IUserInterface
{

    public void Write(string message)
    {
        Console.Write(message);
    }
    public void Writeline(string message)
    {
        Console.WriteLine(message);
    }

    private void WritePrompt(string? message, bool newline = true)
    {
        if (message is { Length: > 0 })
            if (newline)
                Console.WriteLine(message);
            else
                Console.Write(message);
    }

    public string ReadLine(string? message, bool newline = true)
    {
        WritePrompt(message, newline);

        return Console.ReadLine()!;
    }

    public int ReadInt(string? message, bool newline = true)
    {
        bool succes;
        int value;

        WritePrompt(message, newline);

        do
        {
            var input = Console.ReadLine();
            succes = int.TryParse(input, out  value);
            if(!succes)
                Writeline("Неверный формат строки.");
        } 
        while (!succes);

        return value;
    }

    public double ReadDouble(string? message, bool newline = true)
    {
        bool succes;
        double value;

        WritePrompt(message, newline);

        do
        {
            var input = Console.ReadLine();
            succes = double.TryParse(input, out value);
            if (!succes)
                Writeline("Неверный формат строки.");
        }
        while (!succes);

        return value;
    }
}
