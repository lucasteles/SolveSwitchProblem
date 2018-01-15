using SolveSwitchProblem.Enums;


namespace SolveSwitchProblem.Commands
{
    public class FooCommand : ICommand
    {
        public CommandTypes Type => CommandTypes.FOO;

        public string Execute() => "FOO";
                  
    }
}
