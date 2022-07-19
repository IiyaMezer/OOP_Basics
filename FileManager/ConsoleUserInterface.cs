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

    public string ReadLine(string? message, bool newline = true)
    {
        if (message is {Length:>0})
            if (newline)
                Console.WriteLine(message);
            else
                Console.Write(message);
        return Console.ReadLine()!;
    }
}
