using NotificationsApp.Models;
using NotificationsApp.Services.Singleton;

namespace NotificationsApp.Services.FactoryPattern
{
    public class SMSNotificationService : INotificationService
    {
        public void Send(Notification notification)
        {
            NotificationLogger.Instance.Log($"Sending SMS to {notification.Recipient}: {notification.Message}");
        }
    }
}
