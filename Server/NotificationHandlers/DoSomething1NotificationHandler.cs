
namespace Server.NotificationHandlers;

public class DoSomething1NotificationHandler : MediatR.INotificationHandler<Notifications.DoSomethingNotification>
{
    public DoSomething1NotificationHandler() : base()
    {
    }

    public async Task Handle(Notifications.DoSomethingNotification notification, CancellationToken cancellationToken)
    {
        await Task.Run(() =>
        {

            string message =
            ToString() + " - " +
            notification.SomeProperty.ToUpper();

            Console.WriteLine(message);
            System.Diagnostics.Debug.WriteLine(message);

        }, cancellationToken);
    }
}