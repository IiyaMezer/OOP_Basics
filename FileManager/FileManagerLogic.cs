
namespace FileManager;
public class FileManagerLogic
{
    private readonly IUserInterface _Userinterface;

    public FileManagerLogic(IUserInterface Userinterface)
    {
        _Userinterface = Userinterface;
    }
    public void Start()
    {
        _Userinterface.Writeline("Манагер версия 1,0");

        bool iswork = true;

        do
        {
            var input = _Userinterface.ReadLine(">", false);

            if (input == "quit")
                iswork = false;
            else
            {
                _Userinterface.Writeline($"Введа комманда {input}");
            }

        } while (iswork);
    }
}