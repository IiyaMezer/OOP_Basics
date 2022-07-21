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

    /// <summary>
    /// Убрать из имени файла формат.
    /// </summary>
    /// <param name="str"имя файла></param>
    /// <returns>имя файла без формата</returns>
    private string RemoveEnd(string str)
    {
        if (str.Length < 4)
        {
            return string.Empty;
        }

        return str[..^4];
    }

    /// <summary>
    /// Добваление в имя файла суффикса, для обозначения копии.
    /// </summary>
    /// <param name="flie">файл</param>
    /// <returns>суффикс</returns>
    private string AddSuff(FileInfo file)
    {

        string name = RemoveEnd(file.Name) ;
        string suff = "";

        if (file.Exists)
        {
            while (name == RemoveEnd(file.Name))
            {
                suff += "(copy)";
                name += suff;
            }
        }
            
        return suff;
    }
    /// <summary>
    /// Возвращает формат файла
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    private string AddFormat(string str)
    {
        
        return str.Substring(str.Length - 4);
    }
    public override void Execute(string[] args)
    {
        if (string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.Writeline("Необходимо указать имя копируемого файла.");
            return;
        }

        var file_source = args[1];

        FileInfo file;

        if (!Path.IsPathRooted(file_source))
        {
            file_source = Path.Combine(_FileManager.CurrDir.FullName, file_source);

        }

        file = new FileInfo(file_source);

        if (!file.Exists)
        {
            _UserInterface.Writeline("Файла не существует");
            return;
        }
        file.CopyTo(RemoveEnd(file.Name) + AddSuff(file) + AddFormat(file.Name), true);


        _UserInterface.Writeline($"Файл {file.Name} скопирован в текущий каталог с суффиксом {AddSuff(file)}.");
    }
}
