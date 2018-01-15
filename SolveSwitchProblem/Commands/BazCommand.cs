using SolveSwitchProblem.Enums;


namespace SolveSwitchProblem.Commands
{
    public class BazCommand : ICommand
    {
        public CommandTypes Type => CommandTypes.BAZ;

        public string Execute() => "BAZ";
                  
    }
}
