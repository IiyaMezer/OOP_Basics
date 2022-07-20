
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
            var command_name = args[0];

            if (command_name == "quit")
            {
                iswork = false;
                continue;
            }

            if (!Commands.TryGetValue(command_name, out var command))
            {
                _Userinterface.Writeline($"Комманды {command_name} не существует,");
                _Userinterface.Writeline("Для справки введие help, для выхда - quit");
                continue;
            }

            try
            {
                command.Execute(args);
            }
            catch (Exception error)
            {
                _Userinterface.Writeline($"При выполнении {command_name} произошла ошибка:");
                _Userinterface.Writeline(error.Message);
                throw;
            }

        } while (iswork);
    }

}