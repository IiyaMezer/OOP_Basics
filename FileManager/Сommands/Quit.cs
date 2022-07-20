using FileManager.Сommands.Base;

namespace FileManager.Сommands;
public class Quit : Command
{
    private readonly FileManagerLogic _Filemanager;
    public override string Description => "Завершение работы";

    public Quit(FileManagerLogic Filemanager ) => _Filemanager = Filemanager;

    public override void Execute(string[] args)
    {
        _Filemanager.Stop();
    }
}