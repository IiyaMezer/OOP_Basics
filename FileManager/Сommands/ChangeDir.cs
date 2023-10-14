using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class ChangeDir : Command
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Изменение текущего каталога";

    public ChangeDir(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }
    



    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.Writeline("Для смены каталога необходимо указать целевой каталог.");
            return;
        }

        var dir_path = args[1];
       
        DirectoryInfo directory;

        if (dir_path == "..")
        {
            directory = _FileManager.CurrDir.Parent;
            if (directory is null)
            {
                _UserInterface.Writeline("невозможно подняться по дереву каталогов");
                return;
            }
        }
        else if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrDir.FullName, dir_path);
        
        directory = new DirectoryInfo(dir_path);
        
        if (! directory.Exists)
        {
            _UserInterface.Writeline("Директория не сущетвует");
            return;
        }

        _FileManager.CurrDir = directory;

        _UserInterface.Writeline($"Переключение на директорию {directory.FullName} успешно");

        Directory.SetCurrentDirectory(directory.FullName);
    }
}