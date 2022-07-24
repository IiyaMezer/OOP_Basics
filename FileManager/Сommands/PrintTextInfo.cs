using FileManager.Сommands.Base;

namespace FileManager.Сommands; 
public class PrintTextInfo : Command
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "вывод информации о тектовом файле.";

    public PrintTextInfo(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        throw new NotImplementedException();
    }
}