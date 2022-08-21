using Server.Commands;

namespace Server.CommandHandlers;

public class DoSomething3CommandHandler : MediatR.RequestHandler<DoSomething3Command, string>
{
    public DoSomething3CommandHandler() : base()
    {
    }

    protected override string Handle(DoSomething3Command request)
    {
        var result = request.SomeProperty.ToUpper();

        Console.WriteLine(result);
        System.Diagnostics.Debug.WriteLine(result);

        return result;
    }
}