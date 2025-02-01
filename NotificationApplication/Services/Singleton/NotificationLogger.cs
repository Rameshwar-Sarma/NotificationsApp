//Singleton Design Pattern
namespace NotificationsApp.Services.Singleton
{
    public class NotificationLogger
    {
        private static readonly Lazy<NotificationLogger> instance = new(() => new NotificationLogger());

        private NotificationLogger() { }

        public static NotificationLogger Instance => instance.Value;

        public string LogInformation { get; set; }

        public void Log(string message)
        {
            LogInformation += $"Log entry: {message} at {DateTime.Now.ToString()}";
        }
    }

}
