using MediatR;
using Server.Commands;

namespace Server.commandHandlers;

public class DoSomething2CommandHandler : Object, IRequestHandler<DoSomething2Command>
{
    public DoSomething2CommandHandler() : base()
    {
    }

    public async Task<Unit> Handle(DoSomething2Command request, CancellationToken cancellationToken)
    {
        await Task.Run(() =>
        {
            string result = request.SomeProperty.ToUpper();

            Console.WriteLine(result);
            System.Diagnostics.Debug.WriteLine(result);
        }, cancellationToken);

        return new Unit();
    }
}