namespace CeTestApp.Console;

public class CommandLineArguments
{
    public string[] Args { get; }
    public Command Command { get; }

    public CommandLineArguments(string[] args)
    {
        if (args == null)
            throw new ArgumentException(nameof(args));
        if (args.Length != 1)
            throw new ArgumentException("Console app takes one argument as command");
        
        Args = args;
        Enum.IsDefined(typeof(Command), args.First());

        Command command;
        if (!Enum.TryParse(args.First(), out command))
            throw new ArgumentException($"Unknown command ${args.First()}");

        Command = command;
    }
}