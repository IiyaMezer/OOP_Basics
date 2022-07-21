
using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class PrintDirectoryFiles : Command
{
    private readonly IUserInterface _userInterface;
    private readonly FileManagerLogic _fileManager;
    public override string Description => "Вывод вывод папок и файлов в указанной директории.";

    public PrintDirectoryFiles(IUserInterface userInterface, FileManagerLogic FileManager)
    {
        _userInterface = userInterface;
        _fileManager = FileManager;
    }


    /// <summary>
    /// Расчет размера папки.
    /// </summary>
    /// <param name="directory">путь</param>
    /// <returns>размер в байтах</returns>
    private long DirSize(DirectoryInfo directory)
    {

        long Size = 0;

            FileInfo[] fis = directory.GetFiles();
            foreach (FileInfo fi in fis)
                Size += fi.Length;

            DirectoryInfo[] dis = directory.GetDirectories();
            foreach (DirectoryInfo di in dis)
                Size += DirSize(di);

            return (Size);
    }

    public override void Execute(string[] args)
    {
        var directory = _fileManager.CurrDir;
        _userInterface.Writeline($"Содержимое папки {directory} : ");

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
        _userInterface.Writeline($"Папок {dirsCount}, файлов {filesCount}, cуммарный размер файлов в папке: {total_Length} байт.\r\nРазмер папки {DirSize(_fileManager.CurrDir)} байт");
    }

}