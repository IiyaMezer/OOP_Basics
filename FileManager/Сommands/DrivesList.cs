
using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class DrivesList : Command
{
    private readonly IUserInterface _userInterface;

    public DrivesList(IUserInterface UserInterface)
    {
        _userInterface = UserInterface;
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