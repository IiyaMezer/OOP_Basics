﻿
using FileManager.Сommands;
using FileManager.Сommands.Base;

namespace FileManager;
public class FileManagerLogic
{

    private bool _CanWork = true;

    private readonly IUserInterface _Userinterface;

    public DirectoryInfo CurrDir { get; set; } = new("c:\\");

    public IReadOnlyDictionary<string, Command> Commands { get;}


    public FileManagerLogic(IUserInterface Userinterface)
    {
        _Userinterface = Userinterface;

        var help_command = new Help(Userinterface, this);
        var quit_command = new Quit(this);

        Commands = new Dictionary<string, Command>
        {
            {"drives", new DrivesList(Userinterface)},
            {"dir", new PrintDirectoryFiles(Userinterface , this)},
            {"help", help_command},
            {"?", help_command},
            {"quit", quit_command},
            {"exit", quit_command},

        };
    }

    public void Start()
    {
        _Userinterface.Writeline("Манагер версия 1,0");

        
        do
        {
            var input = _Userinterface.ReadLine(">", false);

            var args = input.Split(' ');
            var command_name = args[0];

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

        } while (_CanWork);
    }

    public void Stop()
    {
        _CanWork = false;
    }
}