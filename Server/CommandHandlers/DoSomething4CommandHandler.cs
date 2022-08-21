using MediatR;
using Server.Commands;

namespace Server.CommandHandlers;

public class DoSomething4CommandHandler : IRequestHandler<DoSomething4Command, string>
{
    public DoSomething4CommandHandler() : base()
    {
    }

    public async Task<string> Handle(DoSomething4Command request, CancellationToken cancellationToken)
    {
        var result = string.Empty;

        await Task.Run(() =>
        {
            result = request.SomeProperty.ToUpper();

            Console.WriteLine(result);
            System.Diagnostics.Debug.WriteLine(result);

        }, cancellationToken);

        return result;
    }
}