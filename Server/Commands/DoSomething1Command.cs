namespace Server.Commands;
// Command - Without Result - Sync
public class DoSomething1Command : Object, MediatR.IRequest
{
    public DoSomething1Command() : base()
    {
    }

    public string SomeProperty { get; set; }
}