namespace Server.Commands;

// Command - With Result (string) - Sync
public class DoSomething3Command : Object, MediatR.IRequest<string>
{
    public DoSomething3Command() : base()
    {
    }

    public string SomeProperty { get; set; }
}