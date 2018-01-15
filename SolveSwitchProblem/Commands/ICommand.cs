using SolveSwitchProblem.Enums;

namespace SolveSwitchProblem.Commands
{
    public interface ICommand
    {
        CommandTypes Type { get;}

        string Execute();
    }
}
