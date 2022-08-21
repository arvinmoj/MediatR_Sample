namespace Server.Commands;

public class DoSomething6Command : Object, MediatR.IRequest<FluentResults.Result<string>>
{
    public DoSomething6Command() : base()
    {
    }

    public string SomeProperty { get; set; }
}