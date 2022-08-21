using Server.Notifications;

namespace Server.NotificationHandlers;

public class DoSomething3NoticationHandler : MediatR.INotificationHandler<Notifications.DoSomethingNotification>
{
    public DoSomething3NoticationHandler() : base()
    {
    }

    public async Task Handle(DoSomethingNotification notification, CancellationToken cancellationToken)
    {
        await Task.Run(() =>
        {
            string message =
            ToString() + " - " +
            notification.SomeProperty.ToUpper();

            Console.WriteLine(message);
            System.Diagnostics.Debug.WriteLine(message);
        });
    }
}