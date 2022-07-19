namespace FileManager;

public class ConsoleUserInterface : IUserInterface
{
    public void Writeline(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadLine(string? message)
    {
        if (message is {Length:>0})
            Console.WriteLine(message);
        return Console.ReadLine()!;
    }
}
