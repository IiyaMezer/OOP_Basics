
using FileManager;

ConsoleUserInterface UI = new();

FileManagerLogic manager = new(UI);

manager.Start();

Console.WriteLine("END...");