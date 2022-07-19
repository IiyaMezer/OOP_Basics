
namespace FileManager;
public interface IUserInterface
{
    void Write(string message);

    void Writeline (string message);

    string ReadLine (string? message, bool newline = true);



}
