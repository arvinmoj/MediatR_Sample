namespace Server.CommandHandlers;

public class DoSomething5Command : MediatR.IRequestHandler<Commands.DoSomething5Command, FluentResults.Result>
{
    public DoSomething5Command() : base()
    {
    }

    public async Task<FluentResults.Result> Handle(Commands.DoSomething5Command request, CancellationToken cancellationToken)
    {
        var result = new FluentResults.Result();

        try
        {
            await Task.Run(() =>
            {

                string value = request.SomeProperty.ToUpper();

                result.WithSuccess(successMessage: "Success Massage");
                result.WithSuccess(successMessage: "Success Massage (Command (5))");

                Console.WriteLine(value);
                System.Diagnostics.Debug.WriteLine(value);

            }, cancellationToken);
        }
        catch (Exception ex)
        {
            result.WithError(errorMessage: ex.Message);
        }

        return result;
    }
}