using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class IndexController : Base.ControllerBase
{

    public IndexController(MediatR.IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public IActionResult Get()
    {
        string message = "Hello, World!";

        return Ok(value: message);
    }

    [HttpGet(template: "test1")]
    public IActionResult Test1()
    {
        Commands.DoSomething1Command command =
            new Commands.DoSomething1Command
            {
                SomeProperty = "Command (1)",

            };
        Mediator.Send(command);

        return Ok(value: "OK");
    }

    [HttpGet(template: "test2")]
    public IActionResult Test2()
    {
        Commands.DoSomething2Command command =
            new Commands.DoSomething2Command
            {
                SomeProperty = "Command (2)",
            };

        Mediator.Send(command);

        return Ok(value: "OK");
    }

    [HttpGet(template: "test3")]
    public IActionResult Test3()
    {
        Commands.DoSomething3Command command =
            new Commands.DoSomething3Command
            {
                SomeProperty = "Command (3)",
            };

        var result = Mediator.Send(command).Result;

        return Ok(value: result);
    }

    [HttpGet(template: "test4")]
    public IActionResult Test4()
    {
        Commands.DoSomething4Command command =
            new Commands.DoSomething4Command
            {
                SomeProperty = "Command (4)",
            };

        string result =
            Mediator.Send(command).Result;

        return Ok(value: result);
    }

    [HttpGet(template: "test5")]
    public IActionResult Test5()
    {
        Commands.DoSomething5Command command =
            new Commands.DoSomething5Command
            {
                SomeProperty = "Command (5)",
            };

        FluentResults.Result result =
            Mediator.Send(command).Result;

        if (result.IsSuccess)
        {
            return Ok(value: result);
        }
        else
        {
            return BadRequest(error: result);
        }
    }

    [HttpGet(template: "test6")]
    public IActionResult Test6()
    {
        Commands.DoSomething6Command command =
            new Commands.DoSomething6Command
            {
                SomeProperty = "Command (6)",
            };

        FluentResults.Result<string> result =
            Mediator.Send(command).Result;

        if (result.IsSuccess)
        {
            return Ok(value: result);
        }
        else
        {
            return BadRequest(error: result.ToResult());
        }
    }

    [HttpGet(template:"test7")]
    public IActionResult Test7()
    {
        try
        {
            Notifications.DoSomethingNotification notification =
                new Notifications.DoSomethingNotification
                {
                    SomeProperty = "Notification Message",
                };

            Mediator.Publish(notification);

            return Ok(value: "IT IS DONE!");

        }
        catch (Exception ex)
        {
            return BadRequest(error: ex.Message);
        }
    }
}