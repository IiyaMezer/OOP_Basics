
using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class PrintDirectoryFiles : Command
{
    private readonly IUserInterface _userInterface;
    private readonly FileManagerLogic _fileManager;

    public PrintDirectoryFiles(IUserInterface userInterface, FileManagerLogic FileManager)
    {
        _userInterface = userInterface;
        _fileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        var directory = _fileManager.CurrDir;
        _userInterface.Writeline($"Содержимое папки{directory}: ");

        var dirsCount = 0;
        foreach (var sub_dir in directory.EnumerateDirectories())
        {
            _userInterface.Writeline($"    d    {sub_dir.Name}");
            dirsCount++;
        }

        var filesCount = 0;
        long total_Length = 0;
        foreach (var file in directory.EnumerateFiles())
        {
            _userInterface.Writeline($"    f    {file.Name}\t{file.Length}");
            filesCount++;
            total_Length += file.Length;
        }
        _userInterface.Writeline("");
        _userInterface.Writeline($"Папок {dirsCount}, файлов {filesCount}, cуммарный размер: {total_Length} байт");
    }

}