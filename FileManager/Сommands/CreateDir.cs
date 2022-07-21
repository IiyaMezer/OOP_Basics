
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
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.Writeline("Необходимо указать имя папки.");
            return;
        }

        var dir_path = args[1];

        DirectoryInfo directory;

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrDir.FullName, dir_path);

        directory = new DirectoryInfo(dir_path);

        if (directory.Exists)
        {
            _UserInterface.Writeline("Директория с таким именем существует.");
            return;
        }
        
        directory.Create();

        _UserInterface.Writeline($"Создана папка с именем {directory.FullName}.");

    }
}