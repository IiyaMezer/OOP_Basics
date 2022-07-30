
using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class DrivesList : Command
{
    private readonly IUserInterface _userInterface;

    public override string Description => "Вывод списка дисков в системе";

    public DrivesList(IUserInterface userInterface)
    {
        _userInterface = userInterface;
    }

    public override void Execute(string[] args)
    {
        var drives = DriveInfo.GetDrives();
        _userInterface.Writeline($"Дисков в файловой системе: {drives.Length}");
        foreach (var drive in drives)
        {
            _userInterface.Writeline(drive.Name);
        }
    }
}