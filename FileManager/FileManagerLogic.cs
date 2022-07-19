﻿
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
    }
}