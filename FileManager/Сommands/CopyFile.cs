using FileManager.Сommands.Base;


namespace FileManager.Сommands;

public class CopyFile : Command
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Копия файла по указанному пути.";

    public CopyFile(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        if (string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.Writeline("Необходимо указать имя папки.");
            return;
        }

        var file_path = args[2];
        var file_source = args[1];

        FileInfo file;

        if (!Path.IsPathRooted(file_path) && !Path.IsPathRooted(file_source))
        {
            file_path = Path.Combine(_FileManager.CurrDir.FullName, file_path);
            file_source = Path.Combine(_FileManager.CurrDir.FullName, file_source);

        }

        file = new FileInfo(file_source);

        if (file.Exists)
        {
            file.CopyTo(file_path + file.Name + "(copy)", true);
        }

        _UserInterface.Writeline($"Файл {file.FullName} скопирован по указнному пути.");
    }
}
