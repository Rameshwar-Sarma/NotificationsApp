namespace NotificationsApp.Services.FactoryPattern
{
    public class NotificationFactory
    {
        public static INotificationService CreateNotificationService(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotificationService(),
                "sms" => new SMSNotificationService(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
}
