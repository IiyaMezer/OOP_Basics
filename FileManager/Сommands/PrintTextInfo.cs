using System.Runtime.InteropServices.ComTypes;
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
    /// <summary>
    /// Расчет количества строк
    /// </summary>
    /// <param name="file">анализируемы файл</param>
    /// <returns>кол-во строк</returns>
    private int LinesCount(FileInfo file)
    {
        int count = 0;

        using (StreamReader textfile = new StreamReader(file.Name))
        {
            string? line;

            while ((line = textfile.ReadLine()) != null)
            {
                count++;
            }
        }
        return count;
    }
    /// <summary>
    /// Подсчет слов в файле
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    private int WordsCount(FileInfo file)
    {
        int count = 0;
        string s = "";

        string[] text;

        using (StreamReader textfile = new StreamReader(file.Name))
        {
            while (textfile.EndOfStream != true)
            {
                s += textfile.ReadLine();
            }
            text = s.Split(' ');
        }
        return text.Length;
    }

    private int CharCount(FileInfo file)
    {
        int charCount = 0;
        using (var textfile = new StreamReader(file.FullName))
        {
            while (textfile.Read() > -1)
            {
                charCount++;
            }
        }
        return charCount;
    }

    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.Writeline("Укажите файл в текущей директории.");
            return;
        }

        var file_path = args[1];

        FileInfo file;

        if (!Path.IsPathRooted(file_path))
            file_path = Path.Combine(_FileManager.CurrDir.FullName, file_path);

        file = new FileInfo(file_path);

        if (!file.Exists)
        {
            _UserInterface.Writeline("Файла в текущей директории не существует.");
            return;
        }
        _UserInterface.Writeline($"   Количество строк в файле {file.Name}:     {LinesCount(file)}");
        _UserInterface.Writeline($"   Количество слов в файле {file.Name}:      {WordsCount(file)}");
        _UserInterface.Writeline($"   Количество символов в файле {file.Name}:  {CharCount(file)}");
    }




}
