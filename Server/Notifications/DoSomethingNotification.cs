namespace Server.Notifications;

public class DoSomethingNotification : Object , MediatR.INotification
{
    public DoSomethingNotification() : base()
    {
    }

    public string SomeProperty { get; set; }
}