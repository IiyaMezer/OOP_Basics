
using FileManager.Сommands;
using FileManager.Сommands.Base;

namespace FileManager;
public class FileManagerLogic
{
    private readonly IUserInterface _Userinterface;

    public DirectoryInfo CurrDir { get; set; } = new("c:\\");

    public IReadOnlyDictionary<string, Command> Commands { get;}


    public FileManagerLogic(IUserInterface Userinterface)
    {
        _Userinterface = Userinterface;

        Commands = new Dictionary<string, Command>
        {
            {"drives", new DrivesList(Userinterface)},
            {"dir", new PrintDirectoryFiles(Userinterface , this)},
        };
    }

    public void Start()
    {
        _Userinterface.Writeline("Манагер версия 1,0");

        bool iswork = true;

        do
        {
            var input = _Userinterface.ReadLine(">", false);

            var args = input.Split(' ');

        } while (iswork);
    }

}