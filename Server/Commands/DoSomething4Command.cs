namespace Server.Commands;

// Command - With Result (string) - ASync
public class DoSomething4Command : Object , MediatR.IRequest<string>
{
    public DoSomething4Command() : base()
    {
    }

    public string SomeProperty { get; set; }
}