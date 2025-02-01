using NotificationsApp.Models;
using NotificationsApp.Services.Singleton;

namespace NotificationsApp.Services.FactoryPattern
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(Notification notification)
        {
            NotificationLogger.Instance.Log($"Sending Email to {notification.Recipient}: {notification.Message}");
        }
    }
}
