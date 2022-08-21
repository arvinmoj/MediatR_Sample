using Server.Commands;

namespace Server.CommandHandlers;

public class DoSomething1CommandHandler : MediatR.RequestHandler<DoSomething1Command>
{
    public DoSomething1CommandHandler() : base()
    {
    }

    protected override void Handle(DoSomething1Command request)
    {
        var result = request.SomeProperty.ToUpper();



    }
}