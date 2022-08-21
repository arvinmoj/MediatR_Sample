namespace Server.Commands;

// Command - Without Result - ASync
public class DoSomething2Command : Object, MediatR.IRequest
{
    public DoSomething2Command() : base()
    {
    }

    public String SomeProperty { get; set; }
}