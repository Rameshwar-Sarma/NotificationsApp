using NotificationsApp.Models;
using NotificationsApp.Services.FactoryPattern;

namespace NotificationsApp.Services.AdapterPattern
{
    public class PushNotificationAdapter : INotificationService
    {
        private readonly PushNotificationService _pushService;

        public PushNotificationAdapter()
        {
            _pushService = new PushNotificationService();
        }

        public void Send(Notification notification)
        {
            _pushService.SendPush(notification.Message, notification.Recipient);
        }
    }
}
