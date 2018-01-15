using SolveSwitchProblem.Enums;

namespace SolveSwitchProblem.Commands
{
    public class BarCommand : ICommand
    {
        public CommandTypes Type => CommandTypes.BAR;

        public string Execute() => "BAR";
                  
    }
}
