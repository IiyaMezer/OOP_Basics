using FileManager.Сommands.Base;

namespace FileManager.Сommands;

public class CopyDir : Command
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Скопировать папку.";

    public CopyDir(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.Writeline("Необходимо указать копируемую папку.");
            return;
        }

        var dir_path = args[1];

        DirectoryInfo directory;

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrDir.FullName, dir_path);

        directory = new DirectoryInfo(dir_path);

        if (!directory.Exists)
        {
            _UserInterface.Writeline("Директории не существует.");
            return;
        }

        foreach (FileInfo file in directory.GetFiles())
        {
            File.Copy(file.FullName, dir_path + "\\" + file.Name, true);
        }

        _UserInterface.Writeline($"Папка {directory.FullName} скопирована.");

    }
}
    