
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
            switch (input)
            {
                case "quit":
                    iswork = false;
                    break;
                case "int":
                    var int_value = _Userinterface.ReadInt("Введице целое число > ");
                    _Userinterface.Writeline($"Введено число:{int_value}");
                    break;
                case "double":
                    var double_value = _Userinterface.ReadDouble("Введице вещетвенное число > ");
                    _Userinterface.Writeline($"Введено число:{double_value}");
                    break;
            }
        } while (iswork);
    }
}