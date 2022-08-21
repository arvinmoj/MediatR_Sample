using Server.Commands;

namespace Server.CommandHandlers;

public class DoSomething6CommandHandler : MediatR.IRequestHandler<Commands.DoSomething6Command, FluentResults.Result<string>>
{
    public DoSomething6CommandHandler() : base()
    {
    }

    public async Task<FluentResults.Result<string>> Handle(DoSomething6Command request, CancellationToken cancellationToken)
    {
        var result = new FluentResults.Result<string>();

        try
        {
            await Task.Run(() =>
            {
                var value = request.SomeProperty.ToUpper();

                result.WithValue(value: value);

                result.WithSuccess(successMessage: "Success Message");
                result.WithSuccess(successMessage: "Success Message (Command(6))");

            }, cancellationToken);
        }
        catch (Exception ex)
        {
            result.WithError(errorMessage: ex.Message);
        }

        return result;
    }
}