using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class DeleteDir : Command
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Удалить уканный каталог.";

    public DeleteDir(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    /// <summary>
    /// Рекусивное удаление, можно было восползоваться методом .delete( , true),
    /// но я о нем узнал уполе написания этого метода.
    /// </summary>
    /// <param name="directory">папка</param>
    private void DelDir(DirectoryInfo directory)
    {
        DirectoryInfo[] subdirs = directory.GetDirectories();
        FileInfo[] files = directory.GetFiles();
        foreach (FileInfo file in files)
        {
            file.Delete();
        }
        foreach (DirectoryInfo df in subdirs)
        {
            DelDir(df);
        }
        if (directory.GetDirectories().Length == 0 && directory.GetFiles().Length == 0) directory.Delete();
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

        if (!directory.Exists)
        {
            _UserInterface.Writeline("Директории не существует.");
            return;
        }

        DelDir(directory);

        _UserInterface.Writeline($"Папка {directory.FullName} удалена.");

    }
}