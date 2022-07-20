
using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class CreateDir : Command
{
    private readonly FileManagerLogic _FileManager;
    private readonly IUserInterface _UserInterface;
    public override string Description => "Создать папку в текущей директории.";

    public CreateDir(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }
    public override void Execute(string[] args)
    {
     //to do
    }
}