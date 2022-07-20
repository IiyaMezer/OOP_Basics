using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Сommands.Base;

namespace FileManager.Сommands
{
    public class Help : Command 

    {
        private readonly IUserInterface _UserInterface;
        private readonly FileManagerLogic _fileManager;
        public override string Description => "Помощь";

        public Help(IUserInterface userInterface, FileManagerLogic fileManager)
        {
            _UserInterface = userInterface;
            _fileManager = fileManager;
        }
        public override void Execute(string[] args)
        {
            _UserInterface.Writeline("Поддерживаются следующие комманды:");

            foreach (var (name, command) in _fileManager.Commands)
            {
                _UserInterface.Writeline($"\t{name}\t{command.Description}");
            
            }
        }
    }
}
