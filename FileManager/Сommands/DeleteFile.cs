using FileManager.Сommands.Base;


namespace FileManager.Сommands;

public class DeleteFile : Command
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Удаляет казанный файл";

    public DeleteFile(IUserInterface UserInterface, FileManagerLogic FileManager)
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

        var file_path = args[1];

        FileInfo file;

        if (!Path.IsPathRooted(file_path))
            file_path = Path.Combine(_FileManager.CurrDir.FullName, file_path);

        file = new FileInfo(file_path);

        if (!file.Exists)
        {
            _UserInterface.Writeline("Файла с таким именем не существует.");
            return;
        }

        file.Delete();

        _UserInterface.Writeline($"Файл {file.FullName} удален.");
    }
}