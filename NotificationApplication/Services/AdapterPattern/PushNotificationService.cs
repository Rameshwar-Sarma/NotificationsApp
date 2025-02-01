using NotificationsApp.Services.Singleton;

namespace NotificationsApp.Services.AdapterPattern
{
    // Assume this is a third-party service
    public class PushNotificationService
    {
        public void SendPush(string message, string recipient)
        {
            NotificationLogger.Instance.Log($"Sending Push Notification to {recipient}: {message}");
        }
    }
}
