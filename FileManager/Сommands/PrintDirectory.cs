
using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class PrintDirectory : Command
{
    private readonly IUserInterface _userInterface;

    public PrintDirectory(IUserInterface userInterface)
    {
        _userInterface = userInterface;
    }

    public override void Execute(string[] args)
    {
        
    }

}