
namespace FileManager.Сommands.Base;
public abstract class Command
{
    public abstract string Description { get; } 
    
    public abstract void Execute(string[] args );

}