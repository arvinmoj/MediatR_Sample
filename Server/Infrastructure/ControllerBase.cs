namespace Base;

public class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
{
    public ControllerBase(MediatR.IMediator mediator) : base()
    {
        Mediator = mediator;
    }

    protected MediatR.IMediator Mediator { get; }
}