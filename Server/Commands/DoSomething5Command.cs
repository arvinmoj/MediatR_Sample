namespace Server.Commands;

// Command - With Result (Fluent Result) - Fluent Result without Result - ASync
public class DoSomething5Command : Object, MediatR.IRequest<FluentResults.Result>
{
    public DoSomething5Command() : base()
    {
    }

    public string SomeProperty { get; set; }
}